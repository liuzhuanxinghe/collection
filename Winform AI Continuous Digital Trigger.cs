using System;
using System.Windows.Forms;
using JYPCI69816H;

/// <summary>
/// JYPCI69816H板卡AI单通道连续数字触发采集
/// 作者：简仪科技 
/// 修改日期：2017.03.14
/// 版本：1.0.0
/// 
/// 使用环境：
/// 1、.NET 4.0以上
/// 驱动版本：
/// 1、JYPCI69816H Driver V1.0.0.0
/// 
/// 该范例是实现AI单通道连续采集，在窗体上可以配置板卡号、通道号、采样率、量程和输入阻抗。
/// 
/// 1、触发源：TRGIN
/// 2、触发条件：Rising, Falling
/// 3、触发条件：只支持button_start Trigger
/// 
/// </summary>
namespace SeeSharpExample.JY.JYPCI69816H
{
    public partial class MainForm : Form
    {
        #region Private Fields
        /// <summary>
        /// AI任务
        /// </summary>
        private JYPCI69816HAITask aitask;

        /// <summary>
        /// 存放AI采集到的数据，容量为100ms样点数
        /// </summary>
        private double[] readValue;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        /// <summary>
        /// 设置comboBox的默认索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_inputImpedance.Items.AddRange(Enum.GetNames(typeof(AIImpedance)));
            comboBox_triggerSource.Items.AddRange(Enum.GetNames(typeof(AIDigitalTriggerSource)));
            comboBox_triggerEdge.Items.AddRange(Enum.GetNames(typeof(AIDigitalTriggerEdge)));
            comboBox_boardNumber.SelectedIndex = 0;
            comboBox_channelNo.SelectedIndex = 0;
            comboBox_triggerSource.SelectedIndex = 0;
            comboBox_triggerEdge.SelectedIndex = 0;
            comboBox_inputImpedance.SelectedIndex = 1;      
        }

        /// <summary>
        /// 启动采集 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                aitask = new JYPCI69816HAITask(comboBox_boardNumber.SelectedIndex);

                //添加通道
                aitask.AddChannel(comboBox_channelNo.SelectedIndex, (double)numericUpDown_inputLowLimit.Value,
                    (double)numericUpDown_inputHighLimit.Value, (AIImpedance)Enum.Parse(typeof(AIImpedance), comboBox_inputImpedance.Text));

                //基本参数配置
                aitask.Mode = AIMode.Continuous;
                aitask.SampleRate = (double)numericUpDown_sampleRate.Value;
                aitask.SamplesToAcquire = (int)numericUpDown_samples.Value;

                //配置触发参数
                aitask.Trigger.Type = AITriggerType.Digital;
                aitask.Trigger.Digital.Source = (AIDigitalTriggerSource)Enum.Parse(typeof(AIDigitalTriggerSource), comboBox_triggerSource.Text, true);
                aitask.Trigger.Digital.Edge = (AIDigitalTriggerEdge)Enum.Parse(typeof(AIDigitalTriggerEdge), comboBox_triggerEdge.Text, true);
                aitask.Trigger.Delay = (double)numericUpDown_triggerDelay.Value;
                aitask.Start();
                readValue = new double[aitask.SamplesToAcquire];

                //启用定时器，禁用参数配置按钮
                timer1.Enabled = true;
                groupBox_genParam.Enabled = false;
                groupBox_trigParam.Enabled = false;
                button_start.Enabled = false;
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stop_Click(object sender, EventArgs e)
        {
            aitask.Stop();
            aitask.Channels.Clear();//把上次启动添加的通道清掉

            //禁用定时器，重新启动参数配置按钮
            timer1.Enabled = false;
            groupBox_genParam.Enabled = true;
            groupBox_trigParam.Enabled = true;
            button_start.Enabled = true;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aitask != null)//判断是否任务存在
            {
                aitask.Stop();
            }
        }

        /// <summary>
        /// 定时器，每10ms刷新一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            //如果本地缓冲区数据足够则读取数据并显示，如果不够，返回
            if (aitask.AvailableSamples >= readValue.Length)
            {
                aitask.ReadData(ref readValue, readValue.Length, -1);
                easyChart1.Plot(readValue);
            }
            
            timer1.Enabled = true;
            return;
        }
        #endregion

        #region Methods
        #endregion
    }
}

