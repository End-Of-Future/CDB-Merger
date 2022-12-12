using System.Data;
using System.Data.SQLite;
// datas��������id	ot	alias	setcode	type	atk	def	level	race	attribute	category
// texts��������id	name	desc	str1	str2	str3	str4	str5	str6	str7	str8	str9	str10	str11	str12	str13	str14	str15	str16
namespace CDB_Merger
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// <para>������ݿ��Ƿ�Ϸ���</para>
        /// <para>Made by F-Ate at 22.12.12</para>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static private bool Filter(string path)
        {
            if (!File.Exists(path))  //������ݿ��Ƿ����
            {
                MessageBox.Show("Invalid operate.\nReason:Database doesn't exists.");  //��Ч����
                return false;  //��ֹ����
            }
            SQLiteConnection con = new SQLiteConnection("data source = " + path);  //�������ݿ�����
            con.Open();  //������
            SQLiteDataAdapter dadp = new SQLiteDataAdapter("SELECT * FROM datas;", con);  //�������ݿ�������
            DataSet ds = new DataSet();  //�������ݼ�
            dadp.Fill(ds);  //�������
            DataTable dt = ds.Tables[0];  //�������ݱ�
            if(  //Ӳ���
                   dt.Columns[0].ColumnName != "id"         //�жϵ�1������
                || dt.Columns[1].ColumnName != "ot"         //�жϵ�2������
                || dt.Columns[2].ColumnName != "alias"      //�жϵ�3������
                || dt.Columns[3].ColumnName != "setcode"    //�жϵ�4������
                || dt.Columns[4].ColumnName != "type"       //�жϵ�5������
                || dt.Columns[5].ColumnName != "atk"        //�жϵ�6������
                || dt.Columns[6].ColumnName != "def"        //�жϵ�7������
                || dt.Columns[7].ColumnName != "level"      //�жϵ�8������
                || dt.Columns[8].ColumnName != "race"       //�жϵ�9������
                || dt.Columns[9].ColumnName != "attribute"  //�жϵ�10������
                || dt.Columns[10].ColumnName != "category"  //�жϵ�11������
                )
            {
                MessageBox.Show("Invalid operate.\nReason:Database is illegal.");  //��Ч����
                return false;  //��ֹ����
            }
            dadp = new SQLiteDataAdapter("SELECT * FROM texts;", con);  //���½������ݿ�������
            ds = new DataSet();  //���½������ݼ�
            dadp.Fill(ds);  //�����������
            dt = ds.Tables[0];  //���½������ݱ�
            if (  //Ӳ���
                   dt.Columns[0].ColumnName != "id"         //�жϵ�1������
                || dt.Columns[1].ColumnName != "name"       //�жϵ�2������
                || dt.Columns[2].ColumnName != "desc"       //�жϵ�3������
                || dt.Columns[3].ColumnName != "str1"       //�жϵ�4������
                || dt.Columns[4].ColumnName != "str2"       //�жϵ�5������
                || dt.Columns[5].ColumnName != "str3"       //�жϵ�6������
                || dt.Columns[6].ColumnName != "str4"       //�жϵ�7������
                || dt.Columns[7].ColumnName != "str5"       //�жϵ�8������
                || dt.Columns[8].ColumnName != "str6"       //�жϵ�9������
                || dt.Columns[9].ColumnName != "str7"       //�жϵ�10������
                || dt.Columns[10].ColumnName != "str8"      //�жϵ�11������
                || dt.Columns[11].ColumnName != "str9"      //�жϵ�12������
                || dt.Columns[12].ColumnName != "str10"     //�жϵ�13������
                || dt.Columns[13].ColumnName != "str11"     //�жϵ�14������
                || dt.Columns[14].ColumnName != "str12"     //�жϵ�15������
                || dt.Columns[15].ColumnName != "str13"     //�жϵ�16������
                || dt.Columns[16].ColumnName != "str14"     //�жϵ�17������
                || dt.Columns[17].ColumnName != "str15"     //�жϵ�18������
                || dt.Columns[18].ColumnName != "str16"     //�жϵ�19������
                )
            {
                MessageBox.Show("Invalid operate.\nReason:Database is illegal.");  //��Ч����
                return false;  //��ֹ����
            }
            return true;  //����ֵ
        }
        public MainForm()  //���캯��
        {
            InitializeComponent();
        }
        /// <summary>
        /// <para>�����ݿ⣬��������Ϊ�����ݿ⡣</para>
        /// <para>����֮ǰ���ȼ�����ݿ�Ϸ��ԡ�</para>
        /// <para></para>
        /// <para>Made by F-Ate at 22.12.12</para>
        /// </summary>
        /// <param name="sender">����ί�еĿؼ�</param>
        /// <param name="e"></param>
        public void Open_As_Main(object sender, EventArgs e)
        {
            openFileDialog1.Title = "��";  //���öԻ������
            openFileDialog1.Filter = "YGOPro ���ݿ�|*.cdb";  //�����ļ�����
            openFileDialog1.FileName = string.Empty;  //����Ĭ���ļ���
            if(openFileDialog1.ShowDialog() == DialogResult.OK)  //��ʾ�Ի���
            {
                if (openFileDialog1.FileNames.Length > 1)  //�ж�ѡ���ļ�����
                {
                    MessageBox.Show("Invalid operate.\nReason:Too many databases are choosed.");  //��Ч����
                    return;  //��ֹ����
                }
                if (Filter(openFileDialog1.FileName))
                {
                    textBox1.Text = openFileDialog1.FileName;  //����textBox1����ʾ�ı�
                }
            }
        }

    }
}