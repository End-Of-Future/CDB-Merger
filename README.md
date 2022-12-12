# CDB-Merger
由F-Ate创建的C#项目。
## 功能
+ 新建数据库。使得该数据库满足下文的要求。
+ 打开 $1$ 个数据库，若符合下文的要求，则将`textBox1.Text` 属性设置为其完整路径或在 `listBox1.Items` 中加入项，项为其完整路径。
+ 打开多个数据库，在 `listBox1.Items` 中加入项，项为其全部的符合下文要求的数据库的完整路径。
+ 合并数据库。需使用 `INSERT OR IGNORE` 或 `INSERT OR REPLACE` 语句。取决于 `忽略重复项IToolStripMenuItem.Checked` 属性与 `替换重复项RToolStripMenuItem.Checked` 属性。
## 数据库要求
SQLite数据库。  
有 $2$ 个表：`datas` 和 `texts`。  
对于 `datas` 表，需有以下列。列名和列的类型已给出：
|id|ot|alias|setcode|type|atk|def|level|race|attribute|category|
|--|--|-----|-------|----|---|---|-----|----|---------|--------|
|integer|integer|integer|integer|integer|integer|integer|integer|integer|integer|integer|
|primary key|  

对于 `texts` 表，需有以下列。列名和列的类型已给出：
|id|name|desc|str1|str2|str3|str4|str5|str6|str7|str8|str9|str10|str11|str12|str13|str14|str15|str16|
|--|----|----|----|----|----|----|----|----|----|----|----|-----|-----|-----|-----|-----|-----|-----|
|integer|text|text|text|text|text|text|text|text|text|text|text|text|text|text|text|text|text|text|
|primary key|
## 窗体控件（组件）列表
+ `label1`  
+ `label2`  
+ `textBox1`  
+ `listBox1`  
+ `menuStrip1`  
+ + `文件FToolStripMenuItem`  
+ + + `新建NToolStripMenuItem`  
+ + + `打开ToolStripMenuItem`  
+ + + + `主数据库AToolStripMenuItem`  
+ + + + `其他数据库OToolStripMenuItem`  
+ + + `toolStripSeparator1`  
+ + + `合并MToolStripMenuItem`  
+ + `--数据DToolStripMenuItem`  
+ + + `忽略重复项IToolStripMenuItem`  
+ + + `替换重复项RToolStripMenuItem`  
+ + `--关于AToolStripMenuItem`  
+ + + `源代码开源ToolStripMenuItem`  
+ + + `制作团队ToolStripMenuItem`  
+ `saveFileDialog1`  
+ `openFileDialog1`  
## 代码规范
对于委托方法，需使用 `public` 访问修饰符。  
对于非委托方法，需使用 `private` 访问修饰符。  
可以创建 `MainForm` 类以外的类。  
尽量让其他合作伙伴能轻而易举的看懂你的代码。  
对于每个注释，若该行内有非注释代码，则注释与非注释代码间要间隔 $2$ 个空格以上。  
对于每个方法，要添加署名信息。  
## 创作者
如果你参与了项目的完成，便可以把名字写在下方。  
+ F-Ate
