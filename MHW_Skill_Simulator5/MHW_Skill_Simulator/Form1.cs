using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
enum skillNum
{
    s1,
    s2,
    s3,
    s4,
}
namespace MHW_Skill_Simulator
{
    public partial class Form1 : Form
    {
        //제노지바 장비//
        string xeno = "예리도 소모를 절반으로 억제한다. / 가끔 보우건의 탄과 활의 병을 소모하지 않고 발사할 수 있다.";
        string xenoName = "명검 / 탄환 절약";
        int xenoCount = 0;
        int xenoStatCount;
        int shrinkCount = 0;
        int SkillCount;
        int specialShootingCount = 0;
        //제노지바 장비//

        public void EquipmentCountClear()
        {
            xenoCount = 0;
            xenoStatCount = 0;
        }

        public void SkillCountClear()
        {
            shrinkCount = 0;
            SkillCount = 0;
            specialShootingCount = 0;

        }

        public void OpenSkillInfo()
        {

        }

        public void ShrinkSkillSkillBoxCheck(ComboBox Box,int IndexCount)
        {
            if (Box.SelectedIndex == IndexCount && SkillName1.Text == "스킬1")
            {
                SkillInfo1("움찔 감소", "Lv1 : 움츠리지 않음.", "Lv2 : 움츠리지 않음. 엉덩방아를 움츠림으로 감소시킨다.", "Lv3 : 움츠림, 엉덩방아를 무효화.", "", "");
            }

            if (Box.SelectedIndex == IndexCount && SkillName1.Text != "스킬1" && SkillName1.Text != "움찔 감소" && SkillName2.Text == "스킬2")
            {
                SkillInfo2("움찔 감소", "Lv1 : 움츠리지 않음.", "Lv2 : 움츠리지 않음. 엉덩방아를 움츠림으로 감소시킨다.", "Lv3 : 움츠림, 엉덩방아를 무효화.", "", "");
            }

            if (Box.SelectedIndex == IndexCount && SkillName1.Text != "스킬1" && SkillName1.Text != "움찔 감소" && SkillName2.Text != "스킬2" && SkillName2.Text != "움찔 감소")
            {
                SkillInfo3("움찔 감소", "Lv1 : 움츠리지 않음.", "Lv2 : 움츠리지 않음. 엉덩방아를 움츠림으로 감소시킨다.", "Lv3 : 움츠림, 엉덩방아를 무효화.", "", "");
            }
        }

        
        public void PropertyDamageResistanceSkillBoxCheck(ComboBox Box, int IndexCount)
        {
            if (Box.SelectedIndex == IndexCount && SkillName1.Text == "스킬1")
            {
                SkillInfo1("속성 피해 내성", "Lv1 : 모든 속성 피해의 효과 시간을 50% 줄인다.", "Lv2 : 모든 속성 피해의 효과 시간을 75% 줄인다.", "Lv3 : 모든 속성 피해를 무효화한다.", "", "");
            }

            if (Box.SelectedIndex == IndexCount && SkillName1.Text != "스킬1" && SkillName1.Text != "속성 피해 내성"&&SkillName2.Text=="스킬2")
            {
                SkillInfo2("속성 피해 내성", "Lv1 : 모든 속성 피해의 효과 시간을 50% 줄인다.", "Lv2 : 모든 속성 피해의 효과 시간을 75% 줄인다.", "Lv3 : 모든 속성 피해를 무효화한다.", "", "");
            }

            if (Box.SelectedIndex == IndexCount && SkillName1.Text != "스킬1" && SkillName1.Text != "속성 피해 내성" && SkillName2.Text != "스킬2" && SkillName2.Text != "속성 피해 내성")
            {
                SkillInfo3("속성 피해 내성", "Lv1 : 모든 속성 피해의 효과 시간을 50% 줄인다.", "Lv2 : 모든 속성 피해의 효과 시간을 75% 줄인다.", "Lv3 : 모든 속성 피해를 무효화한다.", "", "");
            }
        }

        public void SpecialShootingSkillBoxCheck(ComboBox Box,int IndexCount)
        {
            if (Box.SelectedIndex == IndexCount && SkillName1.Text == "스킬1")
            {
                SkillInfo1("특수 사격 강화", "Lv1 : 보우건의 특수탄과 활의 용화살, 용의 천천시의 위력이 1.1배.", "Lv2 : 보우건의 특수탄과 활의 용화살, 용의 천천시의 위력이 1.2배.", "", "", "");
            }

            if (Box.SelectedIndex == IndexCount && SkillName1.Text != "스킬1" && SkillName1.Text != "특수 사격 강화" && SkillName2.Text == "스킬2")
            {
                SkillInfo2("특수 사격 강화", "Lv1 : 보우건의 특수탄과 활의 용화살, 용의 천천시의 위력이 1.1배.", "Lv2 : 보우건의 특수탄과 활의 용화살, 용의 천천시의 위력이 1.2배.", "", "", "");
            }

            if (Box.SelectedIndex == IndexCount && SkillName1.Text != "스킬1" && SkillName1.Text != "특수 사격 강화" && SkillName2.Text != "스킬2" && SkillName2.Text != "특수 사격 강화")
            {
                SkillInfo3("특수 사격 강화", "Lv1 : 보우건의 특수탄과 활의 용화살, 용의 천천시의 위력이 1.1배.", "Lv2 : 보우건의 특수탄과 활의 용화살, 용의 천천시의 위력이 1.2배.", "", "", "");
            }

        }




        public void SkillInfo1(string SkillName, string Lv1, string Lv2, string Lv3, string Lv4, string Lv5)
        {
            SkillName1.Text = SkillName;
            FirstLv1.Text = Lv1;
            FirstLv2.Text = Lv2;
            FirstLv3.Text = Lv3;
            FirstLv4.Text = Lv4;
            FirstLv5.Text = Lv5;
            FirstLv1.Visible = true;
            FirstLv2.Visible = true;
            FirstLv3.Visible = true;
            FirstLv4.Visible = true;
            FirstLv5.Visible = true;
        }

        public void SkillInfo2(string SkillName, string Lv1, string Lv2, string Lv3, string Lv4, string Lv5)
        {
            SkillName2.Text = SkillName;
            SecondLv1.Text = Lv1;
            SecondLv2.Text = Lv2;
            SecondLv3.Text = Lv3;
            SecondLv4.Text = Lv4;
            SecondLv5.Text = Lv5;
            SecondLv1.Visible = true;
            SecondLv2.Visible = true;
            SecondLv3.Visible = true;
            SecondLv4.Visible = true;
            SecondLv5.Visible = true;
        }

        public void SkillInfo3(string SkillName, string Lv1, string Lv2, string Lv3, string Lv4, string Lv5)
        {
            SkillName3.Text = SkillName;
            ThirdLv1.Text = Lv1;
            ThirdLv2.Text = Lv2;
            ThirdLv3.Text = Lv3;
            ThirdLv4.Text = Lv4;
            ThirdLv5.Text = Lv5;
            ThirdLv1.Visible = true;
            ThirdLv2.Visible = true;
            ThirdLv3.Visible = true;
            ThirdLv4.Visible = true;
            ThirdLv5.Visible = true;
        }
       
        public void SkillActivation(int SkillCount, string SkillName)
        {

            if (SkillCount == 1 && SkillName1.Text == SkillName)
            {
                FirstLv1.ForeColor = Color.Red;
            }

            if (SkillCount == 2 && SkillName1.Text == SkillName)
            {
                FirstLv1.ForeColor = Color.Red;
                FirstLv2.ForeColor = Color.Red;
            }

            if (SkillCount == 3 && SkillName1.Text == SkillName)
            {
                FirstLv1.ForeColor = Color.Red;
                FirstLv2.ForeColor = Color.Red;
                FirstLv3.ForeColor = Color.Red;
            }

            if (SkillCount == 1 && SkillName2.Text == SkillName)
            {
                SecondLv1.ForeColor = Color.Red;
            }

            if (SkillCount == 2 && SkillName2.Text == SkillName)
            {
                SecondLv1.ForeColor = Color.Red;
                SecondLv2.ForeColor = Color.Red;
            }

            if (SkillCount == 3 && SkillName2.Text == SkillName)
            {
                SecondLv1.ForeColor = Color.Red;
                SecondLv2.ForeColor = Color.Red;
                SecondLv3.ForeColor = Color.Red;
            }

            if (SkillCount == 1 && SkillName3.Text == SkillName)
            {
                ThirdLv1.ForeColor = Color.Red;
            }

            if (SkillCount == 2 && SkillName3.Text == SkillName)
            {
                ThirdLv1.ForeColor = Color.Red;
                ThirdLv2.ForeColor = Color.Red;
            }

            if (SkillCount == 3 && SkillName3.Text == SkillName)
            {
                ThirdLv1.ForeColor = Color.Red;
                ThirdLv2.ForeColor = Color.Red;
                ThirdLv3.ForeColor = Color.Red;
            }
        }

        public void SpecialSkillActivation(string Skill, string Info, int Count, int DemandCount)
        {
            if (Count >= DemandCount)
            {
                Count = DemandCount;
            }

            SpecialSkillName.Text = Skill + "(" + DemandCount + ")";
            SpecialSkillInfo.Text = Info + "(" + Count + "/" + DemandCount + ")";
            SpecialSkillName.Visible = true;
            SpecialSkillInfo.Visible = true;

            if (Count == DemandCount)
            {
                SpecialSkillInfo.ForeColor = Color.Red;
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        public void AllClear()
        {
            FirstLv1.ForeColor = Color.Black;
            FirstLv2.ForeColor = Color.Black;
            FirstLv3.ForeColor = Color.Black;
            SecondLv1.ForeColor = Color.Black;
            SecondLv2.ForeColor = Color.Black;
            SecondLv3.ForeColor = Color.Black;
            XenoImg.Visible = false;
            XenoStatImg.Visible = false;
            FirstLv1.Visible = false;
            FirstLv2.Visible = false;
            FirstLv3.Visible = false;
            FirstLv4.Visible = false;
            FirstLv5.Visible = false;
            SecondLv1.Visible = false;
            SecondLv2.Visible = false;
            SecondLv3.Visible = false;
            SecondLv4.Visible = false;
            SecondLv5.Visible = false;
            ThirdLv1.Visible = false;
            ThirdLv2.Visible = false;
            ThirdLv3.Visible = false;
            ThirdLv4.Visible = false;
            ThirdLv5.Visible = false;
            SpecialSkillName.Visible = false;
            SpecialSkillInfo.Visible = false;
            EquipmentCountClear();
            label2.Visible = true;
            SkillName1.Text = "스킬1";
            SkillName2.Text = "스킬2";
            SkillName3.Text = "스킬3";
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            AllClear();

            string[] headData = { "머리 선택", "제노라지헤드" };
            HeadBox.Items.AddRange(headData);
            HeadBox.SelectedIndex = 0;

            string[] mailData = { "갑옷 선택", "제노라지하이드" };
            MailBox.Items.AddRange(mailData);
            MailBox.SelectedIndex = 0;

            string[] armData = { "팔 선택", "제노라지클로" };
            ArmBox.Items.AddRange(armData);
            ArmBox.SelectedIndex = 0;

            string[] waistData = { "허리 선택", "제노라지파인" };
            WaistBox.Items.AddRange(waistData);
            WaistBox.SelectedIndex = 0;

            string[] legData = { "다리 선택", "제노라지풋" };
            LegBox.Items.AddRange(legData);
            LegBox.SelectedIndex = 0;

            label1.Text = "Monster Hunter Wolrd 스킬 시뮬레이터";
            label2.Text = "모든 부위 세트장착시 이미지 출력";

        }

        public void HeadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HeadBox.SelectedIndex == 1)
            {
                xenoCount++;
                xenoStatCount++;
                specialShootingCount++;
                OpenSkillInfo();
                shrinkCount++;
                SpecialSkillActivation(xenoName, xeno, xenoCount, 3);
                ShrinkSkillSkillBoxCheck(HeadBox, 1);
                SpecialShootingSkillBoxCheck(HeadBox, 1);
                SkillActivation(shrinkCount, "움찔 감소");
                SkillActivation(specialShootingCount, "특수 사격 강화");
            }

            if (xenoCount == 5)
            {
                XenoImg.Visible = true;
                label2.Visible = false;
            }

            if (xenoStatCount > 0)
            {
                XenoStatImg.Visible = true;
            }

        }

        private void MailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MailBox.SelectedIndex == 1)
            {
                OpenSkillInfo();
                xenoCount++;
                SkillCount++;
                xenoStatCount++;
                SpecialSkillActivation(xenoName, xeno, xenoCount, 3);
                PropertyDamageResistanceSkillBoxCheck(MailBox,1);
            }

            SkillActivation(SkillCount, "속성 피해 내성");

            if (xenoCount == 5)
            {
                XenoImg.Visible = true;
                label2.Visible = false;
            }

            if (xenoStatCount > 0)
            {
                XenoStatImg.Visible = true;
            }
        }

        private void ArmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArmBox.SelectedIndex == 1)
            {
                xenoCount++;
                xenoStatCount++;
                OpenSkillInfo();
                shrinkCount++;
                SpecialSkillActivation(xenoName, xeno, xenoCount, 3);
                ShrinkSkillSkillBoxCheck(ArmBox, 1);
            }

            SkillActivation(shrinkCount, "움찔 감소");


            if (xenoCount == 5)
            {
                XenoImg.Visible = true;
                label2.Visible = false;
            }


        }

        private void WaistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WaistBox.SelectedIndex == 1)
            {
                xenoCount++;
            }
            if (xenoCount == 5)
            {
                XenoImg.Visible = true;
                label2.Visible = false;
            }
        }

        private void LegBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LegBox.SelectedIndex == 1)
            {
                xenoCount++;
            }
            if (xenoCount == 5)
            {
                XenoImg.Visible = true;
                label2.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HeadBox.SelectedIndex = 0;
            MailBox.SelectedIndex = 0;
            ArmBox.SelectedIndex = 0;
            WaistBox.SelectedIndex = 0;
            LegBox.SelectedIndex = 0;
            AllClear();
            EquipmentCountClear();
            SkillCountClear();
            SpecialSkillInfo.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
