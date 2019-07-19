using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 云顶之奕助手
{
    public partial class Form1 : Form
    {
        //Form1中的全局变量
        int bfdj,wydb,fqzg,nszl,szj,fjdp,jryd,mc;   //暴风大剑、无用大棒、反曲之弓、女神之泪、锁子甲、负极斗篷、巨人腰带、猫铲的数量
        private FormWindowState formPrevious;   //窗体的初始状态
        private FormFloat formFloat;   //悬浮窗体
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1minus_Click(object sender, EventArgs e)
        {
            if(bfdj != 0)
            {
                bfdj--;
            }
            label1.Text = Convert.ToString(bfdj);
        }

        private void Button1add_Click(object sender, EventArgs e)
        {
            if(bfdj < 9)
            {
                bfdj++;
            }
            label1.Text = Convert.ToString(bfdj);
        }

        private void Button2minus_Click(object sender, EventArgs e)
        {
            if (wydb != 0)
            {
                wydb--;
            }
            label2.Text = Convert.ToString(wydb);
        }

        private void Button2add_Click(object sender, EventArgs e)
        {
            if (wydb < 9)
            {
                wydb++;
            }
            label2.Text = Convert.ToString(wydb);
        }

        private void Button3minus_Click(object sender, EventArgs e)
        {
            if (fqzg != 0)
            {
                fqzg--;
            }
            label3.Text = Convert.ToString(fqzg);
        }

        private void Button3add_Click(object sender, EventArgs e)
        {
            if (fqzg < 9)
            {
                fqzg++;
            }
            label3.Text = Convert.ToString(fqzg);
        }

        private void Button4minus_Click(object sender, EventArgs e)
        {
            if (nszl != 0)
            {
                nszl--;
            }
            label4.Text = Convert.ToString(nszl);
        }

        private void Button4add_Click(object sender, EventArgs e)
        {
            if (nszl < 9)
            {
                nszl++;
            }
            label4.Text = Convert.ToString(nszl);
        }

        private void Button5minus_Click(object sender, EventArgs e)
        {
            if (szj != 0)
            {
                szj--;
            }
            label5.Text = Convert.ToString(szj);
        }

        private void Button5add_Click(object sender, EventArgs e)
        {
            if (szj < 9)
            {
                szj++;
            }
            label5.Text = Convert.ToString(szj);
        }

        private void Button6minus_Click(object sender, EventArgs e)
        {
            if (fjdp != 0)
            {
                fjdp--;
            }
            label6.Text = Convert.ToString(fjdp);
        }

        private void Button6add_Click(object sender, EventArgs e)
        {
            if (fjdp < 9)
            {
                fjdp++;
            }
            label6.Text = Convert.ToString(fjdp);
        }

        private void Button7minus_Click(object sender, EventArgs e)
        {
            if (jryd != 0)
            {
                jryd--;
            }
            label7.Text = Convert.ToString(jryd);
        }

        private void Button7add_Click(object sender, EventArgs e)
        {
            if (jryd < 9)
            {
                jryd++;
            }
            label7.Text = Convert.ToString(jryd);
        }

        private void Button8minus_Click(object sender, EventArgs e)
        {
            if (mc != 0)
            {
                mc--;
            }
            label8.Text = Convert.ToString(mc);
        }

        private void Button8add_Click(object sender, EventArgs e)
        {
            if (mc < 9)
            {
                mc++;
            }
            label8.Text = Convert.ToString(mc);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().Show();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formFloat.Hide();   //隐藏悬浮窗体
            RestoreWindow();    //恢复主窗体
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)    //调整窗体透明度
        {
            Form1 form1 = this;
            form1.Opacity = (double)(trackBar1.Value) / 100;
        }

        private void Update_Label()   //更新物品数量的显示
        {
            label1.Text = Convert.ToString(bfdj);    //更新暴风大剑的数量
            label2.Text = Convert.ToString(wydb);    //更新无用大棒的数量
            label3.Text = Convert.ToString(fqzg);    //更新反曲之弓的数量
            label4.Text = Convert.ToString(nszl);    //更新女神之泪的数量
            label5.Text = Convert.ToString(szj);     //更新锁子甲的数量
            label6.Text = Convert.ToString(fjdp);    //更新负极斗篷的数量
            label7.Text = Convert.ToString(jryd);    //更新巨人腰带的数量
            label8.Text = Convert.ToString(mc);      //更新猫铲的数量
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formPrevious = this.WindowState;
            formFloat = new FormFloat(this);
            int bfdj = Convert.ToInt32(label1.Text.ToString().Trim());   //暴风大剑的数量
            int wydb = Convert.ToInt32(label2.Text.ToString().Trim());   //无用大棒的数量
            int fqzg = Convert.ToInt32(label3.Text.ToString().Trim());   //反曲之弓的数量
            int nszl = Convert.ToInt32(label4.Text.ToString().Trim());   //女神之泪的数量
            int szj = Convert.ToInt32(label5.Text.ToString().Trim());    //锁子甲的数量
            int fjdp = Convert.ToInt32(label6.Text.ToString().Trim());   //负极斗篷的数量
            int jryd = Convert.ToInt32(label7.Text.ToString().Trim());   //巨人腰带的数量
            int mc = Convert.ToInt32(label8.Text.ToString().Trim());   //猫铲的数量（金铲子 我叫猫铲 因为可以合成猫咪）
            //显示物品信息
            toolTip1.SetToolTip(pictureBox1, "暴风大剑\n+20攻击力");
            toolTip1.SetToolTip(pictureBox9, "暴风大剑\n+20攻击力");
            toolTip1.SetToolTip(pictureBox2, "无用大棒\n+20%技能伤害");
            toolTip1.SetToolTip(pictureBox10, "无用大棒\n+20%技能伤害");
            toolTip1.SetToolTip(pictureBox3, "反曲之弓\n+15%攻击速度");
            toolTip1.SetToolTip(pictureBox11, "反曲之弓\n+15%攻击速度");
            toolTip1.SetToolTip(pictureBox4, "女神之泪\n+20法力值");
            toolTip1.SetToolTip(pictureBox12, "女神之泪\n+20法力值");
            toolTip1.SetToolTip(pictureBox5, "锁子甲\n+20护甲");
            toolTip1.SetToolTip(pictureBox13, "锁子甲\n+20护甲");
            toolTip1.SetToolTip(pictureBox6, "负极斗篷\n+20%魔抗");
            toolTip1.SetToolTip(pictureBox14, "负极斗篷\n+20%魔抗");
            toolTip1.SetToolTip(pictureBox7, "巨人腰带\n+200生命值");
            toolTip1.SetToolTip(pictureBox15, "巨人腰带\n+200生命值");
            toolTip1.SetToolTip(pictureBox8, "金铲子\n能用来做点什么");
            toolTip1.SetToolTip(pictureBox16, "金铲子\n能用来做点什么");
            toolTip1.SetToolTip(pictureBox17, "无尽之刃\n+100%暴击伤害");
            toolTip1.SetToolTip(pictureBox18, "海克斯科技枪刃\n+25%全能吸血");
            toolTip1.SetToolTip(pictureBox25, "海克斯科技枪刃\n+25%全能吸血");
            toolTip1.SetToolTip(pictureBox19, "神圣之剑\n每秒+5%暴击\n(上限100%)");
            toolTip1.SetToolTip(pictureBox26, "神圣之剑\n每秒+5%暴击\n(上限100%)");
            toolTip1.SetToolTip(pictureBox20, "朔极之矛\n用技能后每次普攻\n恢复最大法力值的20%");
            toolTip1.SetToolTip(pictureBox27, "朔极之矛\n用技能后每次普攻\n恢复最大法力值的20%");
            toolTip1.SetToolTip(pictureBox21, "守护天使\n阵亡后可复活\n(复活后为500生命值)");
            toolTip1.SetToolTip(pictureBox28, "守护天使\n阵亡后可复活\n(复活后为500生命值)");
            toolTip1.SetToolTip(pictureBox22, "饮血剑\n普攻伤害\n35%吸血");
            toolTip1.SetToolTip(pictureBox29, "饮血剑\n普攻伤害\n35%吸血");
            toolTip1.SetToolTip(pictureBox23, "基克的先驱\n邻格友军\n+10%攻速");
            toolTip1.SetToolTip(pictureBox30, "基克的先驱\n邻格友军\n+10%攻速");
            toolTip1.SetToolTip(pictureBox24, "幽梦之灵\n装备者也视为刺客");
            toolTip1.SetToolTip(pictureBox31, "幽梦之灵\n装备者也视为刺客");
            toolTip1.SetToolTip(pictureBox32, "灭世者的死亡之帽\n+50%技能伤害");
            toolTip1.SetToolTip(pictureBox33, "鬼索的狂暴之刃\n每次普攻+5%攻速\n(无上限)");
            toolTip1.SetToolTip(pictureBox40, "鬼索的狂暴之刃\n每次普攻+5%攻速\n(无上限)");
            toolTip1.SetToolTip(pictureBox34, "卢登的回声\n技能造成200点溅射伤害");
            toolTip1.SetToolTip(pictureBox41, "卢登的回声\n技能造成200点溅射伤害");
            toolTip1.SetToolTip(pictureBox35, "钢铁烈焰之匣\n开打时：邻格友军+200护盾");
            toolTip1.SetToolTip(pictureBox42, "钢铁烈焰之匣\n开打时：邻格友军+200护盾");
            toolTip1.SetToolTip(pictureBox36, "离子火花\n敌人每次释放技能掉200血");
            toolTip1.SetToolTip(pictureBox43, "离子火花\n敌人每次释放技能掉200血");
            toolTip1.SetToolTip(pictureBox37, "莫雷洛秘典\n技能造成目标\n10%最大HP伤害");
            toolTip1.SetToolTip(pictureBox44, "莫雷洛秘典\n技能造成目标\n10%最大HP伤害");
            toolTip1.SetToolTip(pictureBox38, "悠米\n装备者也视为法师");
            toolTip1.SetToolTip(pictureBox45, "悠米\n装备者也视为法师");
            toolTip1.SetToolTip(pictureBox39, "急速火炮\n普攻不会被闪避\n射程翻倍");
            toolTip1.SetToolTip(pictureBox46, "斯塔缇克电刃\n每3下普攻\n造成100点\n溅射伤害");
            toolTip1.SetToolTip(pictureBox51, "斯塔缇克电刃\n每3下普攻\n造成100点\n溅射伤害");
            toolTip1.SetToolTip(pictureBox47, "幻影之舞\n装备者闪避\n所有暴击攻击");
            toolTip1.SetToolTip(pictureBox52, "幻影之舞\n装备者闪避\n所有暴击攻击");
            toolTip1.SetToolTip(pictureBox48, "苦行僧之刃\n普攻有几率\n使敌人缩小1星");
            toolTip1.SetToolTip(pictureBox53, "苦行僧之刃\n普攻有几率\n使敌人缩小1星");
            toolTip1.SetToolTip(pictureBox49, "巨型九头蛇\n普攻造成装备者\n10%最大HP伤害");
            toolTip1.SetToolTip(pictureBox54, "巨型九头蛇\n普攻造成装备者\n10%最大HP伤害");
            toolTip1.SetToolTip(pictureBox50, "破败王者之刃\n装备者也视为剑士");
            toolTip1.SetToolTip(pictureBox57, "破败王者之刃\n装备者也视为剑士");
            toolTip1.SetToolTip(pictureBox55, "炽天使之拥\n有人用技能时\n充能+20法力值");
            toolTip1.SetToolTip(pictureBox56, "冰霜之心\n邻格敌人\n-20%攻速");
            toolTip1.SetToolTip(pictureBox61, "冰霜之心\n邻格敌人\n-20%攻速");
            toolTip1.SetToolTip(pictureBox58, "沉默之刃\n普攻有几率\n对敌人造成沉默");
            toolTip1.SetToolTip(pictureBox62, "沉默之刃\n普攻有几率\n对敌人造成沉默");
            toolTip1.SetToolTip(pictureBox59, "救赎\n装备者阵亡时\n附近友军恢复1000血");
            toolTip1.SetToolTip(pictureBox63, "救赎\n装备者阵亡时\n附近友军恢复1000血");
            toolTip1.SetToolTip(pictureBox60, "暗裔\n装备者也视为恶魔");
            toolTip1.SetToolTip(pictureBox66, "暗裔\n装备者也视为恶魔");
            toolTip1.SetToolTip(pictureBox64, "荆棘之甲\n反弹35%\n普攻伤害");
            toolTip1.SetToolTip(pictureBox65, "破刃者\n普攻有几率\n对敌人造成缴械");
            toolTip1.SetToolTip(pictureBox70, "破刃者\n普攻有几率\n对敌人造成缴械");
            toolTip1.SetToolTip(pictureBox67, "红BUFF\n普攻造成2.5%\n的灼烧伤害");
            toolTip1.SetToolTip(pictureBox71, "红BUFF\n普攻造成2.5%\n的灼烧伤害");
            toolTip1.SetToolTip(pictureBox68, "骑士之誓\n装备者也视为骑士");
            toolTip1.SetToolTip(pictureBox72, "骑士之誓\n装备者也视为骑士");
            toolTip1.SetToolTip(pictureBox69, "龙爪\n装备者获得\n83%魔抗");
            toolTip1.SetToolTip(pictureBox73, "灵风\n开打时：\n放逐一名\n敌人5秒");
            toolTip1.SetToolTip(pictureBox77, "灵风\n开打时：\n放逐一名\n敌人5秒");
            toolTip1.SetToolTip(pictureBox74, "卢安娜的飓风\n攻击2名额外敌人\n造成50%的伤害");
            toolTip1.SetToolTip(pictureBox78, "卢安娜的飓风\n攻击2名额外敌人\n造成50%的伤害");
            toolTip1.SetToolTip(pictureBox75, "狂徒铠甲\n装备者每秒恢复\n3%最大HP值");
            toolTip1.SetToolTip(pictureBox79, "冰霜之锤\n装备者也视为极地");
            toolTip1.SetToolTip(pictureBox80, "冰霜之锤\n装备者也视为极地");
            toolTip1.SetToolTip(pictureBox76, "自然之力\n人口+1");
        }

        private void Label1_TextChanged(object sender, EventArgs e)   //物品数量改变时,将能合成的装备进行高亮显示
        {
            //把能够合成的装备进行高亮显示       
            Graphics g = this.CreateGraphics();   //创建Graphics对象
            Pen p1 = new Pen(Brushes.Red, 4);     //红色画笔
            Pen p2 = new Pen(this.BackColor, 4);  //用窗体背景色当画笔颜色,这样可以擦去红线
            if (bfdj >= 2)   //至少2把暴风大剑才能合成无尽之刃,使无尽之刃的图标高亮
            {
                Rectangle rect = pictureBox17.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //当暴风大剑不足2把时,去除高亮
            {
                Rectangle rect = pictureBox17.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && wydb > 0)   //至少1把暴风大剑、1把无用大棒才能合成海克斯科技枪刃
            {
                Rectangle rect = pictureBox18.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox25.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox18.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox25.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && fqzg > 0)   //至少1把反曲之弓、1把暴风大剑合成神圣之剑
            {
                Rectangle rect = pictureBox19.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox26.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox19.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox26.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && nszl > 0)   //至少1把暴风大剑、1个女神之泪合成朔极之矛
            {
                Rectangle rect = pictureBox20.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox27.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox20.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox27.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && szj > 0)   //至少1把暴风大剑、1个锁子甲合成守护天使
            {
                Rectangle rect = pictureBox21.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox28.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox21.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox28.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && fjdp > 0)   //至少1把暴风大剑、1个负极斗篷合成饮血剑
            {
                Rectangle rect = pictureBox22.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox29.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox22.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox29.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && jryd > 0)   //至少1把暴风大剑、1个巨人腰带合成基克的先驱
            {
                Rectangle rect = pictureBox23.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox30.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox23.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox30.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (bfdj > 0 && mc > 0)   //至少1把暴风大剑、1个猫铲合成幽梦之灵
            {
                Rectangle rect = pictureBox24.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox31.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox24.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox31.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb >= 2)   //至少2把无用大棒合成灭世者的死亡之帽
            {
                Rectangle rect = pictureBox32.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox32.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb > 0 && fqzg > 0)   //至少1把无用大棒、1个反曲之弓合成鬼索的狂暴之刃
            {
                Rectangle rect = pictureBox33.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox40.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox33.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox40.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb > 0 && nszl > 0)   //至少1把无用大棒、1个女神之泪合成卢登的回声
            {
                Rectangle rect = pictureBox34.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox41.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox34.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox41.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb > 0 && szj > 0)   //至少1把无用大棒、1个锁子甲合成钢铁烈焰之匣
            {
                Rectangle rect = pictureBox35.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox42.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox35.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox42.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb > 0 && fjdp > 0)   //至少1把无用大棒、1个负极斗篷合成离子火花
            {
                Rectangle rect = pictureBox36.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox43.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox36.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox43.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb > 0 && jryd > 0)   //至少1把无用大棒、1个巨人腰带合成莫雷洛秘典
            {
                Rectangle rect = pictureBox37.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox44.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox37.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox44.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (wydb > 0 && mc > 0)   //至少1把无用大棒、1个猫铲合成悠米
            {
                Rectangle rect = pictureBox38.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox45.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox38.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox45.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fqzg >= 2)   //至少2把反曲之弓合成急速火炮
            {
                Rectangle rect = pictureBox39.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox39.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fqzg > 0 && nszl > 0)   //至少1把反曲之弓、1个女神之泪合成斯塔缇克电刃
            {
                Rectangle rect = pictureBox46.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox51.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox46.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox51.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fqzg > 0 && szj > 0)   //至少1把反曲之弓、1个锁子甲合成幻影之舞
            {
                Rectangle rect = pictureBox47.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox52.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox47.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox52.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fqzg > 0 && fjdp > 0)   //至少1把反曲之弓、1个负极斗篷合成苦行僧之刃
            {
                Rectangle rect = pictureBox48.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox53.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox48.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox53.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fqzg > 0 && jryd > 0)   //至少1把反曲之弓、1个巨人腰带合成巨型九头蛇
            {
                Rectangle rect = pictureBox49.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox54.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox49.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox54.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fqzg > 0 && mc > 0)   //至少1把反曲之弓、1个猫铲合成破败王者之刃
            {
                Rectangle rect = pictureBox50.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox57.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox50.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox57.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (nszl >= 2)   //至少2个女神之泪合成炽天使之拥
            {
                Rectangle rect = pictureBox55.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox55.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (nszl > 0 && szj > 0)   //至少1个女神之泪、1个锁子甲合成冰霜之心
            {
                Rectangle rect = pictureBox56.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox61.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox56.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox61.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (nszl > 0 && fjdp > 0)   //至少1个女神之泪、1个负极斗篷合成沉默之刃
            {
                Rectangle rect = pictureBox58.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox62.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox58.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox62.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (nszl > 0 && jryd > 0)   //至少1个女神之泪、1个巨人腰带合成救赎
            {
                Rectangle rect = pictureBox59.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox63.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox59.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox63.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (nszl > 0 && mc > 0)   //至少1个女神之泪、1个猫铲合成暗裔
            {
                Rectangle rect = pictureBox60.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox66.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox60.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox66.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (szj >= 2)   //至少2个锁子甲合成荆棘之甲
            {
                Rectangle rect = pictureBox64.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox64.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (szj > 0 && fjdp > 0)   //至少1个锁子甲、1个负极斗篷合成破刃者
            {
                Rectangle rect = pictureBox65.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox70.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox65.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox70.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (szj > 0 && jryd > 0)   //至少1个锁子甲、1个巨人腰带合成红BUFF
            {
                Rectangle rect = pictureBox67.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox71.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox67.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox71.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (szj > 0 && mc > 0)   //至少1个锁子甲、1个猫铲合成骑士之誓
            {
                Rectangle rect = pictureBox68.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox72.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox68.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox72.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fjdp >= 2)   //至少2个负极斗篷合成龙爪
            {
                Rectangle rect = pictureBox69.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox69.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fjdp > 0 && jryd > 0)   //至少1个负极斗篷、1个巨人腰带合成灵风
            {
                Rectangle rect = pictureBox73.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox77.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox73.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox77.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (fjdp > 0 && mc > 0)   //至少1个负极斗篷、1个猫铲合成卢安娜的飓风
            {
                Rectangle rect = pictureBox74.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox78.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox74.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox78.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (jryd >= 2)   //至少2个巨人腰带合成狂徒铠甲
            {
                Rectangle rect = pictureBox75.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox75.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (jryd > 0 && mc > 0)   //至少1个巨人腰带、1个猫铲合成冰霜之锤
            {
                Rectangle rect = pictureBox79.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
                rect = pictureBox80.Bounds;
                g.DrawRectangle(p1, rect);
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox79.Bounds;
                g.DrawRectangle(p2, rect);
                rect = pictureBox80.Bounds;
                g.DrawRectangle(p2, rect);
            }
            if (mc >= 2)   //至少2个猫铲合成自然之力
            {
                Rectangle rect = pictureBox76.Bounds;
                g.DrawRectangle(p1, rect);   //边框画成红线
            }
            else   //否则去除高亮
            {
                Rectangle rect = pictureBox76.Bounds;
                g.DrawRectangle(p2, rect);
            }
            //释放内存
            g.Dispose();
            p1.Dispose();
            p2.Dispose();
        }

        //模拟双击合成物品,消耗被合成的小件装备所需数量,当小件不足时去除合成大件的红色高亮边框
        private void PictureBox17_DoubleClick(object sender, EventArgs e)   //双击无尽之刃
        {
            if(bfdj >= 2)  //俩把暴风大剑
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox17.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj -= 2;
                Update_Label();  
            }
        }

        private void PictureBox18_DoubleClick(object sender, EventArgs e)  //双击海克斯科技枪刃
        {
            if (bfdj > 0 && wydb > 0)   //至少1把暴风大剑、1把无用大棒
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox18.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox25.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                wydb--;
                Update_Label();
            }
        }

        private void PictureBox19_DoubleClick(object sender, EventArgs e)    //双击神圣之剑
        {
            if (bfdj > 0 && fqzg > 0)   //至少1把反曲之弓、1把暴风大剑
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox19.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox26.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                fqzg--;
                Update_Label();
            }
        }

        private void PictureBox20_DoubleClick(object sender, EventArgs e)    //双击朔极之矛
        {
            if (bfdj > 0 && nszl > 0)   //至少1把暴风大剑、1个女神之泪
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox20.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox27.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                nszl--;
                Update_Label();
            }
        }

        private void PictureBox21_DoubleClick(object sender, EventArgs e)   //双击守护天使
        {
            if (bfdj > 0 && szj > 0)   //至少1把暴风大剑、1个锁子甲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox21.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox28.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                szj--;
                Update_Label();
            }
        }

        private void PictureBox22_DoubleClick(object sender, EventArgs e)   //双击饮血剑
        {
            if (bfdj > 0 && fjdp > 0)   //至少1把暴风大剑、1个负极斗篷
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox22.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox29.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                fjdp--;
                Update_Label();
            }
        }

        private void PictureBox23_DoubleClick(object sender, EventArgs e)   //双击基克的先驱
        {
            if (bfdj > 0 && jryd > 0)   //至少1把暴风大剑、1个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox23.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox30.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                jryd--;
                Update_Label();
            }
        }

        private void PictureBox24_DoubleClick(object sender, EventArgs e)   //双击幽梦之灵
        {
            if (bfdj > 0 && mc > 0)   //至少1把暴风大剑、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox24.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox31.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                bfdj--;
                mc--;
                Update_Label();
            }
        }

        private void PictureBox32_DoubleClick(object sender, EventArgs e)    //双击灭世者的死亡之帽
        {
            if (wydb >= 2)   //至少2把无用大棒
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox32.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb -= 2;
                Update_Label();
            }
        }

        private void PictureBox33_DoubleClick(object sender, EventArgs e)   //双击鬼索的狂暴之刃
        {
            if (wydb > 0 && fqzg > 0)   //至少1把无用大棒、1个反曲之弓
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox33.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox40.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb--;
                fqzg--;
                Update_Label();
            }
        }

        private void PictureBox34_DoubleClick(object sender, EventArgs e)   //双击卢登的回声
        {
            if (wydb > 0 && nszl > 0)   //至少1把无用大棒、1个女神之泪
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox34.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox41.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb--;
                nszl--;
                Update_Label();
            }
        }

        private void PictureBox35_DoubleClick(object sender, EventArgs e)    //双击钢铁烈焰之匣
        {
            if (wydb > 0 && szj > 0)   //至少1把无用大棒、1个锁子甲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox35.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox42.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb--;
                nszl--;
                Update_Label();
            }
        }

        private void PictureBox36_DoubleClick(object sender, EventArgs e)   //双击离子火花
        {
            if (wydb > 0 && fjdp > 0)   //至少1把无用大棒、1个负极斗篷
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox36.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox43.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb--;
                fjdp--;
                Update_Label();
            }
        }

        private void PictureBox37_DoubleClick(object sender, EventArgs e)  //双击莫雷洛秘典
        {
            if (wydb > 0 && jryd > 0)   //至少1把无用大棒、1个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox37.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox44.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb--;
                jryd--;
                Update_Label();
            }
        }

        private void PictureBox38_DoubleClick(object sender, EventArgs e)   //双击悠米
        {
            if (wydb > 0 && mc > 0)   //至少1把无用大棒、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox38.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox45.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                wydb--;
                mc--;
                Update_Label();
            }
        }

        private void PictureBox39_DoubleClick(object sender, EventArgs e)    //双击急速火炮
        {
            if (fqzg >= 2)   //至少2把反曲之弓
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox39.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fqzg -= 2;
                Update_Label();
            }
        }

        private void PictureBox46_DoubleClick(object sender, EventArgs e)   //双击斯塔缇克电刃
        {
            if (fqzg > 0 && nszl > 0)   //至少1把反曲之弓、1个女神之泪
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox46.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox51.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fqzg--;
                nszl--;
                Update_Label();
            }
        }

        private void PictureBox47_DoubleClick(object sender, EventArgs e)  //双击幻影之舞
        {
            if (fqzg > 0 && szj > 0)   //至少1把反曲之弓、1个锁子甲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox47.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox52.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fqzg--;
                szj--;
                Update_Label();
            }
        }

        private void PictureBox48_DoubleClick(object sender, EventArgs e)     //双击苦行僧之刃
        {
            if (fqzg > 0 && fjdp > 0)   //至少1把反曲之弓、1个负极斗篷
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox48.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox53.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fqzg--;
                fjdp--;
                Update_Label();
            }
        }

        private void PictureBox49_DoubleClick(object sender, EventArgs e)  //双击巨型九头蛇
        {
            if (fqzg > 0 && jryd > 0)   //至少1把反曲之弓、1个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox49.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox54.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fqzg--;
                jryd--;
                Update_Label();
            }
        }

        private void PictureBox50_DoubleClick(object sender, EventArgs e)   //双击破败王者之刃
        {
            if (fqzg > 0 && mc > 0)   //至少1把反曲之弓、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox50.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox57.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fqzg--;
                mc--;
                Update_Label();
            }
        }

        private void PictureBox55_DoubleClick(object sender, EventArgs e)   //双击炽天使之拥
        {
            if (nszl >= 2)   //至少2个女神之泪
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox55.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                nszl -= 2;
                Update_Label();
            }
        }

        private void PictureBox56_DoubleClick(object sender, EventArgs e)   //双击冰霜之心
        {
            if (nszl > 0 && szj > 0)   //至少1个女神之泪、1个锁子甲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox56.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox61.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                nszl--;
                szj--;
                Update_Label();
            }
        }

        private void PictureBox58_DoubleClick(object sender, EventArgs e)   //双击沉默之刃
        {
            if (nszl > 0 && fjdp > 0)   //至少1个女神之泪、1个负极斗篷
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox58.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox62.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                nszl--;
                fjdp--;
                Update_Label();
            }
        }

        private void PictureBox59_DoubleClick(object sender, EventArgs e)   //双击救赎
        {
            if (nszl > 0 && jryd > 0)   //至少1个女神之泪、1个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox59.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox63.Bounds;
                g.DrawRectangle(p, rect);
                nszl--;
                jryd--;
                Update_Label();
            }
        }

        private void PictureBox60_DoubleClick(object sender, EventArgs e)   //双击暗裔
        {
            if (nszl > 0 && mc > 0)   //至少1个女神之泪、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox60.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox66.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                nszl--;
                mc--;
                Update_Label();
            }
        }

        private void PictureBox64_DoubleClick(object sender, EventArgs e)   //双击荆棘之甲
        {
            if (szj >= 2)   //至少2个锁子甲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox64.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                szj -= 2;
                Update_Label();
            }
        }

        private void PictureBox65_DoubleClick(object sender, EventArgs e)   //双击破刃者
        {
            if (szj > 0 && fjdp > 0)   //至少1个锁子甲、1个负极斗篷
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox65.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox70.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                szj--;
                fjdp--;
                Update_Label();
            }
        }

        private void PictureBox67_DoubleClick(object sender, EventArgs e)   //双击红BUFF
        {
            if (szj > 0 && jryd > 0)   //至少1个锁子甲、1个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox67.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox71.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                szj--;
                fjdp--;
                Update_Label();
            }
        }

        private void PictureBox68_DoubleClick(object sender, EventArgs e)   //双击骑士之誓
        {
            if (szj > 0 && mc > 0)   //至少1个锁子甲、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox68.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox72.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                szj--;
                mc--;
                Update_Label();
            }
        }

        private void PictureBox69_DoubleClick(object sender, EventArgs e)   //双击龙爪
        {
            if (fjdp >= 2)   //至少2个负极斗篷
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox69.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fjdp -= 2;
                Update_Label();
            }
        }

        private void PictureBox73_DoubleClick(object sender, EventArgs e)   //双击灵风
        {
            if (fjdp > 0 && jryd > 0)   //至少1个负极斗篷、1个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox73.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox77.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                fjdp--;
                jryd--;
                Update_Label();
            }
        }

        private void PictureBox74_DoubleClick(object sender, EventArgs e)  //双击卢安娜的飓风
        {
            if (fjdp > 0 && mc > 0)   //至少1个负极斗篷、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox74.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox78.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                Update_Label();
            }
        }

        private void PictureBox75_DoubleClick(object sender, EventArgs e)  //双击狂徒铠甲
        {
            if (jryd >= 2)   //至少2个巨人腰带
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox75.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                Update_Label();
            }
        }

        private void PictureBox79_DoubleClick(object sender, EventArgs e)   //双击冰霜之锤
        {
            if (jryd > 0 && mc > 0)   //至少1个巨人腰带、1个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox79.Bounds;
                g.DrawRectangle(p, rect);
                rect = pictureBox80.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                Update_Label();
            }
        }

        private void PictureBox76_DoubleClick(object sender, EventArgs e)   //双击自然之力
        {
            if (mc >= 2)   //至少2个猫铲
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(this.BackColor, 4);
                Rectangle rect = pictureBox76.Bounds;
                g.DrawRectangle(p, rect);
                g.Dispose();
                p.Dispose();
                Update_Label();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                formFloat.Show();
                this.ShowInTaskbar = false;
            }
            else if (this.WindowState != formPrevious)
            {
                formPrevious = this.WindowState;
                this.ShowInTaskbar = true;
            }
        }

        public void RestoreWindow()   //还原主窗体，供悬浮窗口进行调用的
        {
            this.WindowState = formPrevious;
            this.ShowInTaskbar = true;
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);    //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净
        }
    }
}
