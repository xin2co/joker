using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 性别推理器
{
    public partial class Form1 : Form
    {
        // 控件成员变量
        private ProgressBar progressBar;
        private Label progressLabel;
        private Label resultLabel;
        private Label probabilityLabel;
        private PictureBox probabilityPictureBox;

        // 性别选项数组
        private int[] genderOptions = new int[] { 1, 2 }; // 1代表男性，2代表女性
        private string[] americanGenderOptions = new string[] {
    "顺性别女", "女", "跨性别女", "有跨性别经验的女性", "经历过性别转换过程的女性", "跨女性化", "中心女性", "男跨女", "半性取向/半性女", "跨性别女（年轻）", "跨性别女", "跨性别女（澳洲原住民）",
    "顺性别男", "男", "跨性别男", "有跨性别经验的男性", "经历过性别转换过程的男性", "跨男性化", "中心男性", "女跨男", "半性取向/半性男", "跨性别男（年轻）", "跨性别男", "跨性别男（澳洲原住民）",
    "跨性别", "跨性别", "变性", "非二元性别", "性别酷儿", "无性别", "外性别", "底", "底（女性化）", "顶", "同性恋（男）", "同性恋（女）+假小子", "双性性格", "假小子", "性别叛徒", "非常规性别", "非常规性别", "性别流动", "性别颠覆", "双性", "多性", "泛性", "性别创意", "性别扩展", "第三性别", "中性", "全性别", "多性别", "灰性别", "间性别", "独行侠", "不可描述的性别", "双灵", "印度半岛特殊群体", "泰国特殊群体", "墨西哥特殊群体", "阿拉伯半岛特殊群体", "日本第三性别", "男变非二元", "女变非二元", "菲律宾特殊群体", "夏威夷特殊群体", "萨摩亚特殊群体", "印度尼西亚特殊群体", "马里亚纳群岛特殊群体", "埃塞俄比亚特殊群体", "斯瓦希里特殊群体", "刚果第三性别", "恩东戈王国第三性别", "印第安Warao族性转女", "来源不明的词语", "莫哈维族性转女", "莫哈维族性转男", "北美祖尼人特殊群体", "纳瓦霍人特殊群体", "纳瓦霍人特殊群体", "拉科塔语特殊群体", "黑脚族特殊群体", "生理双性人", "双性萨满", "西伯利亚特殊群体", "毛利语特殊群体", "东加特殊群体", "布吉人特殊群体", "布吉人特殊群体", "布吉人双性人", "缅甸特殊群体", "拉丁美洲特殊群体", "仍在思考", "我不用标签", "我拒绝", "选项未列出"
};

        private string[] quirkyGenderOptions = new string[] { "沃尔玛购物袋" };

        // 构造函数
        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
            Check推理按钮状态();
        }

        // 初始化所有组件
        private void InitializeComponents()
        {
            InitializeProgressBar();
            InitializeProgressLabel();
            InitializeResultLabel();
            InitializeProbabilityLabel();
            InitializeBottomControls();
        }

        // 初始化进度条
        private void InitializeProgressBar()
        {
            progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Step = 1,
                Dock = DockStyle.Bottom,
                Visible = false
            };
            this.Controls.Add(progressBar);
            statusStrip1.Dock= DockStyle.Bottom;
        }

        // 初始化进度标签
        private void InitializeProgressLabel()
        {
            progressLabel = new Label
            {
                AutoSize = true,
                Text = "推理中，请稍候...",
                Dock = DockStyle.Bottom,
                Visible = false
            };


        }

        // 初始化结果标签
        private void InitializeResultLabel()
        {
            resultLabel = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Bottom
            };
            groupBox3.Controls.Add(resultLabel);
            InitializeProbabilityPictureBox();

        }

        // 初始化概率标签
        private void InitializeProbabilityLabel()
        {
            probabilityLabel = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Bottom
            };

        }
        private void InitializeBottomControls()
        {
            // 添加概率标签
            this.Controls.Add(probabilityLabel);

            // 添加进度标签
            this.Controls.Add(progressLabel);

            // 确保statusStrip1是最后一个添加的，这样它就会显示在最下面
            this.Controls.Add(statusStrip1);
            statusStrip1.Dock = DockStyle.Bottom;
        }
        // 点击推理按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 禁用按钮，显示进度条和标签
            button1.Enabled = false;
            progressBar.Visible = true;
            progressLabel.Visible = true;

            // 模拟推理过程
            SimulateReasoningProcess().ConfigureAwait(false);
        }

        // 异步模拟推理过程
        private async Task SimulateReasoningProcess()
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                await Task.Delay(20);
                Application.DoEvents();
            }
            await Task.Delay(100);

            // 生成随机概率并显示结果
            int probability = new Random().Next(60, 101);
            DisplayResult(probability);
            DisplayProbability(probability);

            // 隐藏进度条和更新标签文本
            progressBar.Visible = false;
            progressLabel.Text = "推理结束";
            DisplayProbabilityGraph(probability);
        }

        // 显示推理结果
        private void DisplayResult(int probability)
        {
            string result = "";
            switch (toolStripStatusLabel2.Text)
            {
                case "正常版":
                    result = radioButton1.Checked ? "男" : "女";
                    break;
                case "美国版":
                    result = americanGenderOptions[new Random().Next(americanGenderOptions.Length)];
                    break;
                case "猎奇版":
                    result = quirkyGenderOptions[new Random().Next(quirkyGenderOptions.Length)];
                    break;
            }

            resultLabel.Text = $"推理结果：{result}";
            resultLabel.Visible = true;
        }

        // 显示推理概率
        private void DisplayProbability(int probability)
        {
            probabilityLabel.Text = $"推理正确概率：{probability}%";
            probabilityLabel.Visible = true;
        }

        //初始化画图结果图
        private void InitializeProbabilityPictureBox()
        {
            probabilityPictureBox = new PictureBox
            {
                Size = new Size(groupBox3.Width, 160), // 设置PictureBox的大小
                Dock = DockStyle.Fill, // 设置PictureBox停靠在groupBox3的底部
                Visible = false // 初始时不可见，直到推理过程完成后设置可见
            };
            groupBox3.Controls.Add(probabilityPictureBox); // 将PictureBox添加到groupBox3中
        }

        private void DisplayProbabilityGraph(int probability)
        {
            // 创建一个Bitmap对象，用于绘制概率图
            Bitmap bitmap = new Bitmap(probabilityPictureBox.Width, probabilityPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // 清除PictureBox并设置背景色
                g.Clear(Color.White);

                // 根据概率计算矩形的宽度，假设最大概率为100
                int maxWidth = probabilityPictureBox.Width; // 矩形的最大宽度
                int rectangleWidth = (int)((double)probability / 100 * maxWidth); // 根据概率计算矩形的宽度

                // 定义矩形的位置，使其居中
                Rectangle rectangle = new Rectangle(
                    (probabilityPictureBox.Width - rectangleWidth) / 2,
                    (probabilityPictureBox.Height - probabilityPictureBox.Height) / 2,
                    rectangleWidth,
                    probabilityPictureBox.Height); // 矩形的高度等于PictureBox的高度

                // 绘制矩形概率图
                g.FillRectangle(Brushes.LightBlue, rectangle); // 填充矩形
                g.DrawRectangle(Pens.Black, rectangle); // 绘制矩形的边框

                // 添加概率文字
                string text = $"{probability}%";
                Font font = new Font("Arial", 12);
                SizeF textSize = g.MeasureString(text, font);
                g.DrawString(text, font, Brushes.Black,
                    (probabilityPictureBox.Width - textSize.Width) / 2,
                    (probabilityPictureBox.Height - textSize.Height) / 2);
            }

            // 将绘制的Bitmap设置到PictureBox中
            probabilityPictureBox.Image = bitmap;
            probabilityPictureBox.Visible = true; // 设置PictureBox可见
        }


        // 检查推理按钮状态
        private void Check推理按钮状态()
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) && (radioButton1.Checked || radioButton2.Checked);
        }

        // 文本框文本更改事件
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Check推理按钮状态();
        }

        // 单选按钮状态更改事件
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Check推理按钮状态();
        }

        private void 正常人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "正常版";
            美国版ToolStripMenuItem.Checked = false;
            猎奇版ToolStripMenuItem.Checked = false;
            正常人ToolStripMenuItem.Checked = true;
        }

        private void 美国版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "美国版";
            美国版ToolStripMenuItem.Checked = true;
            猎奇版ToolStripMenuItem.Checked = false;
            正常人ToolStripMenuItem.Checked = false;
        }

        private void 猎奇版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "猎奇版";
            美国版ToolStripMenuItem.Checked = false;
            猎奇版ToolStripMenuItem.Checked = true;
            正常人ToolStripMenuItem.Checked = false;
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("春竹,这都不会用重开吧！");
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 打赏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建一个提示框
            MessageBox.Show("给点钱哥", "打赏提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 创建一个新的Form来展示图片
            Form donateForm = new Form();
            PictureBox pictureBox = new PictureBox();

            // 设置PictureBox的属性
            pictureBox.Dock = DockStyle.Fill; // 填充整个窗体
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // 按比例缩放图片
            pictureBox.Image = Properties.Resources.i; // 假设图片资源名为 donateImage

            // 将PictureBox添加到新的Form
            donateForm.Controls.Add(pictureBox);

            // 设置新窗体的属性
            donateForm.Size = new Size(300, 300); // 设置窗体大小
            donateForm.StartPosition = FormStartPosition.CenterScreen; // 居中显示
            donateForm.MinimizeBox = false;
            donateForm.MaximizeBox = false;
            donateForm.ShowIcon = false;

            // 显示图片窗体
            donateForm.ShowDialog();
        }

    }
}