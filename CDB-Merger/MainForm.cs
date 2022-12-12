using System.Data;
using System.Data.SQLite;
// datas表列名：id	ot	alias	setcode	type	atk	def	level	race	attribute	category
// texts表列名：id	name	desc	str1	str2	str3	str4	str5	str6	str7	str8	str9	str10	str11	str12	str13	str14	str15	str16
namespace CDB_Merger
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// <para>检查数据库是否合法。</para>
        /// <para>Made by F-Ate at 22.12.12</para>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static private bool Filter(string path)
        {
            if (!File.Exists(path))  //检查数据库是否存在
            {
                MessageBox.Show("Invalid operate.\nReason:Database doesn't exists.");  //无效操作
                return false;  //中止方法
            }
            SQLiteConnection con = new SQLiteConnection("data source = " + path);  //建立数据库连接
            con.Open();  //打开连接
            SQLiteDataAdapter dadp = new SQLiteDataAdapter("SELECT * FROM datas;", con);  //建立数据库连接桥
            DataSet ds = new DataSet();  //建立数据集
            dadp.Fill(ds);  //填充数据
            DataTable dt = ds.Tables[0];  //建立数据表
            if(  //硬检测
                   dt.Columns[0].ColumnName != "id"         //判断第1列列名
                || dt.Columns[1].ColumnName != "ot"         //判断第2列列名
                || dt.Columns[2].ColumnName != "alias"      //判断第3列列名
                || dt.Columns[3].ColumnName != "setcode"    //判断第4列列名
                || dt.Columns[4].ColumnName != "type"       //判断第5列列名
                || dt.Columns[5].ColumnName != "atk"        //判断第6列列名
                || dt.Columns[6].ColumnName != "def"        //判断第7列列名
                || dt.Columns[7].ColumnName != "level"      //判断第8列列名
                || dt.Columns[8].ColumnName != "race"       //判断第9列列名
                || dt.Columns[9].ColumnName != "attribute"  //判断第10列列名
                || dt.Columns[10].ColumnName != "category"  //判断第11列列名
                )
            {
                MessageBox.Show("Invalid operate.\nReason:Database is illegal.");  //无效操作
                return false;  //中止方法
            }
            dadp = new SQLiteDataAdapter("SELECT * FROM texts;", con);  //重新建立数据库连接桥
            ds = new DataSet();  //重新建立数据集
            dadp.Fill(ds);  //重新填充数据
            dt = ds.Tables[0];  //重新建立数据表
            if (  //硬检测
                   dt.Columns[0].ColumnName != "id"         //判断第1列列名
                || dt.Columns[1].ColumnName != "name"       //判断第2列列名
                || dt.Columns[2].ColumnName != "desc"       //判断第3列列名
                || dt.Columns[3].ColumnName != "str1"       //判断第4列列名
                || dt.Columns[4].ColumnName != "str2"       //判断第5列列名
                || dt.Columns[5].ColumnName != "str3"       //判断第6列列名
                || dt.Columns[6].ColumnName != "str4"       //判断第7列列名
                || dt.Columns[7].ColumnName != "str5"       //判断第8列列名
                || dt.Columns[8].ColumnName != "str6"       //判断第9列列名
                || dt.Columns[9].ColumnName != "str7"       //判断第10列列名
                || dt.Columns[10].ColumnName != "str8"      //判断第11列列名
                || dt.Columns[11].ColumnName != "str9"      //判断第12列列名
                || dt.Columns[12].ColumnName != "str10"     //判断第13列列名
                || dt.Columns[13].ColumnName != "str11"     //判断第14列列名
                || dt.Columns[14].ColumnName != "str12"     //判断第15列列名
                || dt.Columns[15].ColumnName != "str13"     //判断第16列列名
                || dt.Columns[16].ColumnName != "str14"     //判断第17列列名
                || dt.Columns[17].ColumnName != "str15"     //判断第18列列名
                || dt.Columns[18].ColumnName != "str16"     //判断第19列列名
                )
            {
                MessageBox.Show("Invalid operate.\nReason:Database is illegal.");  //无效操作
                return false;  //中止方法
            }
            return true;  //返回值
        }
        public MainForm()  //构造函数
        {
            InitializeComponent();
        }
        /// <summary>
        /// <para>打开数据库，并把他设为主数据库。</para>
        /// <para>设置之前，先检查数据库合法性。</para>
        /// <para></para>
        /// <para>Made by F-Ate at 22.12.12</para>
        /// </summary>
        /// <param name="sender">触发委托的控件</param>
        /// <param name="e"></param>
        public void Open_As_Main(object sender, EventArgs e)
        {
            openFileDialog1.Title = "打开";  //设置对话框标题
            openFileDialog1.Filter = "YGOPro 数据库|*.cdb";  //设置文件类型
            openFileDialog1.FileName = string.Empty;  //设置默认文件名
            if(openFileDialog1.ShowDialog() == DialogResult.OK)  //显示对话框
            {
                if (openFileDialog1.FileNames.Length > 1)  //判断选定文件数量
                {
                    MessageBox.Show("Invalid operate.\nReason:Too many databases are choosed.");  //无效操作
                    return;  //中止方法
                }
                if (Filter(openFileDialog1.FileName))
                {
                    textBox1.Text = openFileDialog1.FileName;  //更改textBox1的显示文本
                }
            }
        }

    }
}