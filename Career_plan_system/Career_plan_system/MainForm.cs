using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Career_plan_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xinli001.com/ceshi/712/start");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xinli001.com/ceshi/422/start");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("E:/C#/Career_plan_system/Career_plan_system/pic/070.jpg");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能尚在开发中");
        }
        
        private void addItems(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem.ToString() == "销售管理")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("销售总监");
                this.listBox2.Items.Add("销售经理");
                this.listBox2.Items.Add("销售主管");
                this.listBox2.Items.Add("客户经理/主管");
                this.listBox2.Items.Add("区域销售总监/经理");
                this.listBox2.Items.Add("渠道/分销总监");
                this.listBox2.Items.Add("渠道/分销主管");
                this.listBox2.Items.Add("业务拓展主管/经理");
                this.listBox2.Items.Add("团购经理/主管");
                this.listBox2.Items.Add("售前/售后管理");
                this.listBox2.Items.Add("零售/百货/连锁管理");
            }
            if (this.listBox1.SelectedItem.ToString() == "销售支持")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("销售行政经理/主管");
                this.listBox2.Items.Add("销售行政专员/助理");
                this.listBox2.Items.Add("商务助理");
                this.listBox2.Items.Add("商务经理");
                this.listBox2.Items.Add("业务分析");
                this.listBox2.Items.Add("销售培训讲师");
            }
            if (this.listBox1.SelectedItem.ToString() == "市场/市场拓展/公关")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("市场营销经理/主管");
                this.listBox2.Items.Add("市场营销专员/助理");
                this.listBox2.Items.Add("市场策划/企划");
                this.listBox2.Items.Add("公关经理/主管");
                this.listBox2.Items.Add("公关专员");
                this.listBox2.Items.Add("媒介经理/主管");
                this.listBox2.Items.Add("媒介专员/媒介购买");
                this.listBox2.Items.Add("促销督导");
                this.listBox2.Items.Add("市场调研与分析");
                this.listBox2.Items.Add("产品、品牌经理/产品、品牌主管");
                this.listBox2.Items.Add("产品/品牌专员");
                this.listBox2.Items.Add("市场专员/市场助理");
                this.listBox2.Items.Add("会务专员");
                this.listBox2.Items.Add("市场拓展");
            }
            if (this.listBox1.SelectedItem.ToString() == "商务/采购/贸易")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("外贸、贸易经理/外贸、贸易主管");
                this.listBox2.Items.Add("外贸/贸易专员");
                this.listBox2.Items.Add("商务专员/助理");
                this.listBox2.Items.Add("商务经理/主管");
                this.listBox2.Items.Add("采购经理/主管");
                this.listBox2.Items.Add("采购专员/助理");
                this.listBox2.Items.Add("报关员");
                this.listBox2.Items.Add("业务跟单");
            }
            if (this.listBox1.SelectedItem.ToString() == "计算机软、硬件/互联网/IT")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("首席技术官CTO/首席信息官 CIO");
                this.listBox2.Items.Add("技术总监/经理");
                this.listBox2.Items.Add("技术支持/维护经理");
                this.listBox2.Items.Add("技术支持/维护工程师");
                this.listBox2.Items.Add("软件工程师");
                this.listBox2.Items.Add("高级软件工程师");
                this.listBox2.Items.Add("互联网软件开发工程师");
                this.listBox2.Items.Add("软件测试");
                this.listBox2.Items.Add("高级硬件工程师");
                this.listBox2.Items.Add("硬件工程师");
                this.listBox2.Items.Add("硬件测试");
                this.listBox2.Items.Add("质量工程师");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("产品经理/主管");
                this.listBox2.Items.Add("研发工程师");
                this.listBox2.Items.Add("数据库开发工程师");
                this.listBox2.Items.Add("数据库管理员");
                this.listBox2.Items.Add("信息技术专员");
                this.listBox2.Items.Add("信息技术经理/主管");
                this.listBox2.Items.Add("系统管理员");
                this.listBox2.Items.Add("系统工程师");
                this.listBox2.Items.Add("系统分析师/架构师");
                this.listBox2.Items.Add("网站运营管理");
                this.listBox2.Items.Add("网站编辑");
                this.listBox2.Items.Add("网页设计/制作");
                this.listBox2.Items.Add("网络与信息安全工程师");
                this.listBox2.Items.Add("网络管理员");
                this.listBox2.Items.Add("网络工程师");
                this.listBox2.Items.Add("语音/视频/图形");
                this.listBox2.Items.Add("游戏设计/开发");
                this.listBox2.Items.Add("ERP技术/开发应用");
            }
            if (this.listBox1.SelectedItem.ToString() == "建筑/房地产/装修/物业")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("建筑师/土建工程师");
                this.listBox2.Items.Add("高级建筑工程师/总工");
                this.listBox2.Items.Add("房地产中介/交易");
                this.listBox2.Items.Add("给排水工程/暖通/制冷工程");
                this.listBox2.Items.Add("工程监理/质量工程师");
                this.listBox2.Items.Add("结构工程师");
                this.listBox2.Items.Add("物业招商/租赁/租售");
                this.listBox2.Items.Add("物业维修");
                this.listBox2.Items.Add("物业经理/主管");
                this.listBox2.Items.Add("物业管理专员/助理");
                this.listBox2.Items.Add("招商经理/主管");
                this.listBox2.Items.Add("铁路/道路/桥梁技术");
                this.listBox2.Items.Add("室内外装潢设计");
                this.listBox2.Items.Add("施工员");
                this.listBox2.Items.Add("造价师/预算师");
                this.listBox2.Items.Add("房地产开发/策划/评估");
                this.listBox2.Items.Add("电气设计");
                this.listBox2.Items.Add("城市规划/景观设计");
                this.listBox2.Items.Add("测绘/测量");
                this.listBox2.Items.Add("智能大厦/综合布线/弱电");
            }
            if (this.listBox1.SelectedItem.ToString() == "金融/银行/证券/投资")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("证券总监/部门经理");
                this.listBox2.Items.Add("证券/期货/外汇经纪人");
                this.listBox2.Items.Add("银行经理/主任");
                this.listBox2.Items.Add("银行会计/柜员");
                this.listBox2.Items.Add("信贷管理/资信评估");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("外汇交易/基金/国债经理人");
                this.listBox2.Items.Add("投资/理财服务");
                this.listBox2.Items.Add("融资总监");
                this.listBox2.Items.Add("融资经理/融资主管/专员");
                this.listBox2.Items.Add("客户经理/主管");
                this.listBox2.Items.Add("客户服务");
                this.listBox2.Items.Add("风险管理/控制/稽查");
                this.listBox2.Items.Add("储备经理人");
            }
            if (this.listBox1.SelectedItem.ToString() == "汽车")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("销售/经纪人");
                this.listBox2.Items.Add("设计工程师");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("装配工艺工程师");
                this.listBox2.Items.Add("研发工程师");
                this.listBox2.Items.Add("发动机/底盘/总装工程师");
                this.listBox2.Items.Add("机械工程师");
                this.listBox2.Items.Add("电子工程师");
                this.listBox2.Items.Add("4S店管理");
                this.listBox2.Items.Add("汽车安全性能工程师");
                this.listBox2.Items.Add("零配件销售");
                this.listBox2.Items.Add("理赔专员/顾问");
                this.listBox2.Items.Add("检验检测");
                this.listBox2.Items.Add("汽车修理");
                this.listBox2.Items.Add("装饰美容");
                this.listBox2.Items.Add("二手车评估师");
            }
            if (this.listBox1.SelectedItem.ToString() == "生产/加工/制造")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("工厂厂长/副厂长");
                this.listBox2.Items.Add("生产经理/车间主任");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("质量管理");
                this.listBox2.Items.Add("生产主管/督导/组长");
                this.listBox2.Items.Add("制造工程师");
                this.listBox2.Items.Add("项目工程师");
                this.listBox2.Items.Add("维修工程师");
                this.listBox2.Items.Add("铸造/锻造/注塑工程师");
                this.listBox2.Items.Add("工业工程师");
                this.listBox2.Items.Add("生产计划");
                this.listBox2.Items.Add("设备管理");
                this.listBox2.Items.Add("产品开发/技术或工艺");
                this.listBox2.Items.Add("化验/检验");
                this.listBox2.Items.Add("仓库物料");
                this.listBox2.Items.Add("采购管理");
            }
            if (this.listBox1.SelectedItem.ToString() == "交通/仓储/物流")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("运输经理/主管");
                this.listBox2.Items.Add("物流经理/主管");
                this.listBox2.Items.Add("物流专员/助理");
                this.listBox2.Items.Add("供应链管理");
                this.listBox2.Items.Add("海运/空运/船运操作人员");
                this.listBox2.Items.Add("调度员");
                this.listBox2.Items.Add("快递员/速递员");
                this.listBox2.Items.Add("航空/列车/船舶乘务");
                this.listBox2.Items.Add("铸造/锻造/注塑工程师");
                this.listBox2.Items.Add("单证员");
                this.listBox2.Items.Add("仓库经理/主管");
                this.listBox2.Items.Add("仓库管理员");
                this.listBox2.Items.Add("搬运工");
                this.listBox2.Items.Add("司机");
            }
            if (this.listBox1.SelectedItem.ToString() == "零售业")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("店员/营业员/导购员");
                this.listBox2.Items.Add("店长/卖场经理");
                this.listBox2.Items.Add("理货员/陈列员");
                this.listBox2.Items.Add("收银员");
                this.listBox2.Items.Add("促销专员/导购");
                this.listBox2.Items.Add("兼职店员");
                this.listBox2.Items.Add("防损员/内保");
                this.listBox2.Items.Add("招商经理/主管");
                this.listBox2.Items.Add("奢侈品业务");
            }
            if (this.listBox1.SelectedItem.ToString() == "医疗/护理/保健/美容")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("医生/医师");
                this.listBox2.Items.Add("医药代表");
                this.listBox2.Items.Add("药库主任/药剂师");
                this.listBox2.Items.Add("宠物护理/兽医");
                this.listBox2.Items.Add("心理医生");
                this.listBox2.Items.Add("医药质检");
                this.listBox2.Items.Add("针灸推拿");
                this.listBox2.Items.Add("健身教练");
                this.listBox2.Items.Add("整形/美容/美发/美甲师");
                this.listBox2.Items.Add("护士/护理人员");
            }
            if (this.listBox1.SelectedItem.ToString() == "生物/制药/医疗器械")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("医疗器械推广");
                this.listBox2.Items.Add("医药研发/药品注册");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("药品生产/质量管理");
                this.listBox2.Items.Add("生物工程/生物制药");
                this.listBox2.Items.Add("招商经理/主管");
                this.listBox2.Items.Add("临床研究/协调");
            }
            if (this.listBox1.SelectedItem.ToString() == "人力资源")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("人力资源经理/主管");
                this.listBox2.Items.Add("人力资源专员/助理");
                this.listBox2.Items.Add("招聘经理/主管");
                this.listBox2.Items.Add("招聘专员/助理");
                this.listBox2.Items.Add("培训经理/主管");
                this.listBox2.Items.Add("培训专员/助理/培训师");
                this.listBox2.Items.Add("薪酬福利/绩效考核/员工关系");
                this.listBox2.Items.Add("猎头顾问/助理");
            }
            if (this.listBox1.SelectedItem.ToString() == "客户服务/技术支持")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("客户服务总监");
                this.listBox2.Items.Add("客户服务经理/主管");
                this.listBox2.Items.Add("客户服务专员/助理");
                this.listBox2.Items.Add("售前/售后技术支持管理");
                this.listBox2.Items.Add("售前/售后技术支持工程师");
                this.listBox2.Items.Add("客户咨询热线/呼叫中心人员");
                this.listBox2.Items.Add("客户协调");
            }
            if (this.listBox1.SelectedItem.ToString() == "行政/后勤")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("行政总监");
                this.listBox2.Items.Add("行政经理/主管/办公室主任");
                this.listBox2.Items.Add("行政专员/助理");
                this.listBox2.Items.Add("前台/总机/接待");
                this.listBox2.Items.Add("经理助理/秘书/文员");
                this.listBox2.Items.Add("图书/资料/档案管理");
                this.listBox2.Items.Add("后勤");
                this.listBox2.Items.Add("合同管理");
                this.listBox2.Items.Add("电脑操作/打字/录入员");
            }
            if (this.listBox1.SelectedItem.ToString() == "通信技术")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("无线/射频通信工程师");
                this.listBox2.Items.Add("移动通信工程师");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("研发工程师");
                this.listBox2.Items.Add("有线传输工程师");
                this.listBox2.Items.Add("通信技术工程师");
                this.listBox2.Items.Add("通信电源工程师");
                this.listBox2.Items.Add("数据通信工程师");
                this.listBox2.Items.Add("电信网络工程师");
                this.listBox2.Items.Add("电信交换工程师");
            }
            if (this.listBox1.SelectedItem.ToString() == "教育/培训")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("教师/培训师");
                this.listBox2.Items.Add("招生/课程顾问");
                this.listBox2.Items.Add("教学/教务管理人员");
                this.listBox2.Items.Add("教授/讲师/助教");
                this.listBox2.Items.Add("教育产品开发");
                this.listBox2.Items.Add("教练");
                this.listBox2.Items.Add("家教");
                this.listBox2.Items.Add("幼教");
            }
            if (this.listBox1.SelectedItem.ToString() == "化工")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("研发工程师");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("实验技术员/研究员");
                this.listBox2.Items.Add("油漆/化工涂料");
                this.listBox2.Items.Add("化学制剂研发");
                this.listBox2.Items.Add("化学技术");
                this.listBox2.Items.Add("化学分析");
                this.listBox2.Items.Add("化学操作");
            }
            if (this.listBox1.SelectedItem.ToString() == "广告")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("客户总监/经理");
                this.listBox2.Items.Add("客户主管/专员");
                this.listBox2.Items.Add("业务拓展");
                this.listBox2.Items.Add("文案策划");
                this.listBox2.Items.Add("设计/创意管理");
                this.listBox2.Items.Add("企业策划人员");
                this.listBox2.Items.Add("美术指导");
                this.listBox2.Items.Add("媒介策划/管理");
                this.listBox2.Items.Add("制作执行");
            }
            if (this.listBox1.SelectedItem.ToString() == "服装/纺织/皮革")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("服装/店面/纺织设计");
                this.listBox2.Items.Add("销售/市场推广");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("生产管理");
                this.listBox2.Items.Add("质量管理/验货员(QA /QC)");
                this.listBox2.Items.Add("服装/纺织/皮革跟单");
                this.listBox2.Items.Add("面料辅料开发/采购");
                this.listBox2.Items.Add("服装打样/制版");
                this.listBox2.Items.Add("样衣工");
                this.listBox2.Items.Add("裁床");
            }
            if (this.listBox1.SelectedItem.ToString() == "财会/审计/统计")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("首席财务官 CFO");
                this.listBox2.Items.Add("财务总监");
                this.listBox2.Items.Add("财务经理");
                this.listBox2.Items.Add("财务主管/总帐主管");
                this.listBox2.Items.Add("财务分析经理/主管");
                this.listBox2.Items.Add("会计经理/主管");
                this.listBox2.Items.Add("会计");
                this.listBox2.Items.Add("会计师");
                this.listBox2.Items.Add("成本经理/主管");
                this.listBox2.Items.Add("成本会计");
                this.listBox2.Items.Add("财务分析员");
                this.listBox2.Items.Add("财务/会计助理");
                this.listBox2.Items.Add("财务/出纳员");
                this.listBox2.Items.Add("审计专员/助理");
                this.listBox2.Items.Add("审计经理/主管");
                this.listBox2.Items.Add("税务经理/主管");
                this.listBox2.Items.Add("税务专员/助理");
                this.listBox2.Items.Add("统计员");
            }
            if (this.listBox1.SelectedItem.ToString() == "编辑/文案/传媒/影视/新闻")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("总编/副总编/主编");
                this.listBox2.Items.Add("编辑/作家/撰稿人");
                this.listBox2.Items.Add("导演/编导/影视制作");
                this.listBox2.Items.Add("主持人/演员/模特/配音");
                this.listBox2.Items.Add("文案/策划");
                this.listBox2.Items.Add("出版/印刷/发行");
                this.listBox2.Items.Add("校对/录入");
                this.listBox2.Items.Add("排版设计/完稿");
                this.listBox2.Items.Add("摄影师/记者");
                this.listBox2.Items.Add("经纪人");
                this.listBox2.Items.Add("化妆师/造型师/服装/道具");
                this.listBox2.Items.Add("后期制作/音效师");
                this.listBox2.Items.Add("艺术/设计");
            }
            if (this.listBox1.SelectedItem.ToString() == "电子/半导体/仪表仪器")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("自动化工程师");
                this.listBox2.Items.Add("研发工程师");
                this.listBox2.Items.Add("模拟电路设计/应用工程师");
                this.listBox2.Items.Add("电子元器件工程师");
                this.listBox2.Items.Add("电子/电器维修");
                this.listBox2.Items.Add("电子/电气工程师");
                this.listBox2.Items.Add("电路工程师/技术员");
                this.listBox2.Items.Add("项目经理/产品经理");
                this.listBox2.Items.Add("无线电工程师");
                this.listBox2.Items.Add("设备工程师（调试/安装/维护）");
                this.listBox2.Items.Add("嵌入式硬件/软件工程师");
                this.listBox2.Items.Add("音频/视频工程 师/技术员");
                this.listBox2.Items.Add("家用电器/数码产品研发");
                this.listBox2.Items.Add("集成电路IC设计/应用工程师");
                this.listBox2.Items.Add("激光/光电子技术");
                this.listBox2.Items.Add("机电工程师");
                this.listBox2.Items.Add("仪器/仪表/计量");
                this.listBox2.Items.Add("电池/电源开发");
                this.listBox2.Items.Add("产品工艺/规划/制程工程师");
                this.listBox2.Items.Add("测试工程师");
                this.listBox2.Items.Add("半导体技术");
                this.listBox2.Items.Add("版图设计工程师");
                this.listBox2.Items.Add("IC验证工程师");
                this.listBox2.Items.Add("FAE现场应用工程师");
            }
            if (this.listBox1.SelectedItem.ToString() == "法律")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("律师/律师助理");
                this.listBox2.Items.Add("法律顾问");
                this.listBox2.Items.Add("法务人员");
                this.listBox2.Items.Add("产权/专利顾问/专业代理");
                this.listBox2.Items.Add("法律部经理/主任");
            }
            if (this.listBox1.SelectedItem.ToString() == "翻译（口译与笔译）")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("英语类");
                this.listBox2.Items.Add("日语类");
                this.listBox2.Items.Add("韩语类");
                this.listBox2.Items.Add("法语类");
                this.listBox2.Items.Add("俄语类");
                this.listBox2.Items.Add("德语类");
                this.listBox2.Items.Add("其他语种类");
            }
            if (this.listBox1.SelectedItem.ToString() == "高级管理")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("首席执行官CEO/总裁/总经理");
                this.listBox2.Items.Add("首席技术官CTO/首席信息官 CIO");
                this.listBox2.Items.Add("首席运营官 COO");
                this.listBox2.Items.Add("首席财务官 CFO");
                this.listBox2.Items.Add("副总裁/副总经理");
                this.listBox2.Items.Add("分公司/分支机构/办事处经理");
                this.listBox2.Items.Add("总裁助理/总经理助理");
                this.listBox2.Items.Add("合伙人");
                this.listBox2.Items.Add("总监");
            }
            if (this.listBox1.SelectedItem.ToString() == "工程机械")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("工程机械经理");
                this.listBox2.Items.Add("工程机械主管");
                this.listBox2.Items.Add("机械制图员");
                this.listBox2.Items.Add("机械设计师");
                this.listBox2.Items.Add("机械工程师");
                this.listBox2.Items.Add("技术文档工程师");
            }
            if (this.listBox1.SelectedItem.ToString() == "环境科学/环保")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("环境管理/保护");
                this.listBox2.Items.Add("环境工程技术/园林景区");
                this.listBox2.Items.Add("环保技术");
            }
            if (this.listBox1.SelectedItem.ToString() == "咨询/顾问")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("咨询总监");
                this.listBox2.Items.Add("咨询经理/主管");
                this.listBox2.Items.Add("培训师");
                this.listBox2.Items.Add("咨询员");
                this.listBox2.Items.Add("专业顾问");
                this.listBox2.Items.Add("情报信息分析");
            }
            if (this.listBox1.SelectedItem.ToString() == "质控/安检")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("质量管理/测试经理(QA/QC经理)");
                this.listBox2.Items.Add("质量管理/测试主管(QA/QC主管)");
                this.listBox2.Items.Add("质量管理/测试工程师(QA/QC工程师)");
                this.listBox2.Items.Add("质量检验员/测试员");
                this.listBox2.Items.Add("认证工程师/审核员");
                this.listBox2.Items.Add("供应商/采购设备与材料质量管理");
                this.listBox2.Items.Add("安全管理");
                this.listBox2.Items.Add("HSE工程师");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "酒店/餐饮/旅游/娱乐")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("娱乐或餐饮管理");
                this.listBox2.Items.Add("大堂经理/领班");
                this.listBox2.Items.Add("前厅接待/礼仪/迎宾");
                this.listBox2.Items.Add("调酒师/茶艺师");
                this.listBox2.Items.Add("厨师/面点师");
                this.listBox2.Items.Add("营养师");
                this.listBox2.Items.Add("旅游顾问");
                this.listBox2.Items.Add("计划调度");
                this.listBox2.Items.Add("导游/票务");
                this.listBox2.Items.Add("服务员");
                this.listBox2.Items.Add("保安");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "美术/设计/创意")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("平面设计");
                this.listBox2.Items.Add("产品/包装设计");
                this.listBox2.Items.Add("创意指导/总监");
                this.listBox2.Items.Add("展示/装潢设计");
                this.listBox2.Items.Add("美术编辑/美术设计");
                this.listBox2.Items.Add("家具设计");
                this.listBox2.Items.Add("工艺品/珠宝设计");
                this.listBox2.Items.Add("店面/陈列/展览设计");
                this.listBox2.Items.Add("多媒体/动画设计");
                this.listBox2.Items.Add("印刷排版/制版");
                this.listBox2.Items.Add("设计管理人员");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "能源/矿产/地质勘查")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("石油天然气技术人员");
                this.listBox2.Items.Add("空调/热能工程师");
                this.listBox2.Items.Add("核力/火力工程师");
                this.listBox2.Items.Add("电力工程师/技术员");
                this.listBox2.Items.Add("地质勘查");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "学术/科研")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("科研人员");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "保险")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("业务经理/主管");
                this.listBox2.Items.Add("项目经理/主管");
                this.listBox2.Items.Add("保险代理/经纪人/客户经理");
                this.listBox2.Items.Add("保险顾问/财务规划师");
                this.listBox2.Items.Add("受理");
                this.listBox2.Items.Add("核保理赔");
                this.listBox2.Items.Add("保险内勤");
                this.listBox2.Items.Add("保险精算师");
                this.listBox2.Items.Add("保险产品开发/项目策划");
                this.listBox2.Items.Add("客户服务/续期管理");
                this.listBox2.Items.Add("精算/投资/稽核/法律");
                this.listBox2.Items.Add("保险培训师");
                this.listBox2.Items.Add("储备经理人");
                this.listBox2.Items.Add("契约管理");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "公务员")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("公务员");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "技工")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("普工");
                this.listBox2.Items.Add("钳工/钣工");
                this.listBox2.Items.Add("电工/电焊工/铆焊工");
                this.listBox2.Items.Add("车床/磨床/铣床/冲床工");
                this.listBox2.Items.Add("模具工");
                this.listBox2.Items.Add("空调工/电梯工/锅炉工");
                this.listBox2.Items.Add("水工/木工/油漆工");
                this.listBox2.Items.Add("汽车修理工/机修工");
                this.listBox2.Items.Add("铲车/叉车工");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "在校学生")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("应届毕业生");
                this.listBox2.Items.Add("非应届毕业生/实习生");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "农/林/牧/渔业")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("农/林/牧/渔业");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "普通劳动力/家政服务")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("家政人员");
                this.listBox2.Items.Add("保安保洁");
                this.listBox2.Items.Add("普工");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "兼职/临时/培训生/储备干部")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("储备干部");
                this.listBox2.Items.Add("培训生");
                this.listBox2.Items.Add("其他");
            }
            if (this.listBox1.SelectedItem.ToString() == "销售业务")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("销售代表");
                this.listBox2.Items.Add("客户代表");
                this.listBox2.Items.Add("电话销售");
                this.listBox2.Items.Add("销售工程师");
                this.listBox2.Items.Add("渠道/分销专员");
                this.listBox2.Items.Add("医药销售代表");
                this.listBox2.Items.Add("网站推广");
                this.listBox2.Items.Add("团购业务员");
                this.listBox2.Items.Add("经销商");
            }
            if (this.listBox1.SelectedItem.ToString() == "其他")
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("激光技术");
                this.listBox2.Items.Add("气象");
                this.listBox2.Items.Add("航空航天");
                this.listBox2.Items.Add("安全消防");
                this.listBox2.Items.Add("其他");
            }
            this.label19.Text = this.listBox1.SelectedItem.ToString();
            this.label20.Text = "";
        }

        private void status(object sender, EventArgs e)
        {
            this.label20.Text = this.listBox2.SelectedItem.ToString();
        }
    }
}
