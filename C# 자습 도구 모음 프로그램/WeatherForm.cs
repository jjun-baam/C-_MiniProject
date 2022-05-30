using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 과제_201730206_김준범
{
    public partial class WeatherForm : Form
    {
        string strUrl = "https://www.kma.go.kr/weather/forecast/mid-term-xml.jsp";
        string strCity = "";
        public WeatherForm()
        {
            InitializeComponent();

            cboCity.SelectedIndex = 0;
            lblToday.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using(XmlReader xr = XmlReader.Create(strUrl))
                {
                    string strMsg = "";
                    XmlWriterSettings ws = new XmlWriterSettings();
                    ws.Indent = true;
                    bool bCheck = false;
                    int nCnt = 0;
                    strCity = cboCity.Text;

                    while (xr.Read())
                    {
                        switch (xr.NodeType)
                        {
                            case XmlNodeType.CDATA:
                                {
                                    txtMsg.Text = xr.Value.ToString().Replace("<br />", " ");
                                    break;
                                }
                            case XmlNodeType.Element:
                                {
                                    break;
                                }
                            case XmlNodeType.Text:
                                {
                                    if (xr.Value.Equals(strCity))
                                    {
                                        bCheck = true;
                                    }
                                    if (bCheck)
                                    {
                                        DateTime dt;
                                        bool b = DateTime.TryParse(xr.Value.ToString(), out dt);
                                        if (b)
                                        {
                                            strMsg += "~";
                                        }
                                        strMsg += xr.Value + ",";
                                        nCnt += 1;
                                        if (nCnt > 36)
                                        {
                                            bCheck = false;
                                        }
                                    }
                                    break;
                                }
                            case XmlNodeType.XmlDeclaration:
                                { break; }
                            case XmlNodeType.ProcessingInstruction:
                                { break; }
                            case XmlNodeType.Comment:
                                { break; }
                            case XmlNodeType.EndElement:
                                { break; }
                        }
                    }//while

                    //요일별로 짜르기
                    string[] strTmp = strMsg.Split('~');

                    //요일별 데이터
                    string[] strWh1 = strTmp[1].Split(',');
                    lb1.Text = strWh1[0];
                    lb1_2.Text = "최저: " + strWh1[2] + "℃";
                    lb1_3.Text = "최고: " + strWh1[3] + "℃";
                    lb1_4.Text = strWh1[1];

                    string[] strWh2 = strTmp[2].Split(',');
                    lb2.Text = strWh2[0];
                    lb2_2.Text = "최저: " + strWh2[2] + "℃";
                    lb2_3.Text = "최고: " + strWh2[3] + "℃";
                    lb2_4.Text = strWh2[1];

                    string[] strWh3 = strTmp[3].Split(',');
                    lb3.Text = strWh3[0];
                    lb3_2.Text = "최저: " + strWh3[2] + "℃";
                    lb3_3.Text = "최고: " + strWh3[3] + "℃";
                    lb3_4.Text = strWh3[1];

                    string[] strWh4 = strTmp[4].Split(',');
                    lb4.Text = strWh4[0];
                    lb4_2.Text = "최저: " + strWh4[2] + "℃";
                    lb4_3.Text = "최고: " + strWh4[3] + "℃";
                    lb4_4.Text = strWh4[1];

                    string[] strWh5 = strTmp[5].Split(',');
                    lb5.Text = strWh5[0];
                    lb5_2.Text = "최저: " + strWh5[2] + "℃";
                    lb5_3.Text = "최고: " + strWh5[3] + "℃";
                    lb5_4.Text = strWh5[1];

                    string[] strWh6 = strTmp[6].Split(',');
                    lb6.Text = strWh6[0];
                    lb6_2.Text = "최저: " + strWh6[2] + "℃";
                    lb6_3.Text = "최고: " + strWh6[3] + "℃";
                    lb6_4.Text = strWh6[1];
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}