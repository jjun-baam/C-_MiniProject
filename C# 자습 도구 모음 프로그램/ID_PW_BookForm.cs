using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 과제_201730206_김준범
{
    public partial class ID_PW_BookForm : Form
    {
        private List<IdPw> idpw;//메모리상에 보관
        private string dir = System.IO.Path.Combine(Application.StartupPath, "MyID_PW.txt"); //경로를 묵을때 편함

        public ID_PW_BookForm()
        {
            InitializeComponent();
            idpw = new List<IdPw>(); //생성자에 의해서 초기화
        }

        private void IDPWBook_Load(object sender, EventArgs e)
        {
            if (File.Exists(dir)) //파일이 있으면
            {
                LoadData();
            }
            this.Count.Text = "등록수" + idpw.Count.ToString();
            
            if (idpw.Count > 0)
            {
                ShowRecord(0); //첫번째 데이터를 표시
            }
            btnOK.Text = "추가";
        }

        private void LoadData()
        {
            StreamReader sr = new StreamReader(dir, Encoding.Default);

            while (sr.Peek() >= 0) //-1 : 더이상 읽을 문자가 없을때
            {
                string[] arr = sr.ReadLine().Trim().Split(',');//한줄만 읽기 전체는 ReadEnd, Split는 콤마를 구분으로 나누자

                if (arr[0] != "" && arr[0] != null)
                {
                    IdPw a = new IdPw();
                    a.Num = Convert.ToInt32(arr[0]);//번호 : 인덱스+1
                    a.Name = arr[1];
                    a.ID = arr[2];
                    a.PW = arr[3];

                    idpw.Add(a);
                }
            }
            sr.Close();
            sr.Dispose();
            DisplayData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "입력")
            {
                IdPw a = new IdPw();

                a.Num = idpw.Count + 1;
                a.Name = txtName.Text.Trim(); //양쪽 공백 없애기
                a.ID = txtID.Text.Trim();
                a.PW = txtPW.Text.Trim();

                idpw.Add(a);
                DisplayData(); //출력
            }
            else {
                ClerTextBox();
                btnOK.Text = "입력";
            }
        }

        private void ClerTextBox()
        {
            txtName.Text = txtID.Text = txtPW.Text = String.Empty;
        }
        private void DisplayData()
        {
            var q = (from a in idpw select a).ToList();
            this.dataGridView.DataSource = q;
        }
        private void DisplayData(string query)
        {
            var q = (from a in idpw
                     where
                         a.Name == query ||
                         a.ID == query ||
                         a.PW == query
                     select a).ToList();
            this.dataGridView.DataSource = q;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (idpw.Count > 0)
            {
                SaveData();
            }
        }
        private void SaveData()
        {                  
            StringBuilder sb = new StringBuilder();          
            int index = 0; //인덱스 재정렬
            foreach (IdPw a in idpw)
            {
                sb.Append(String.Format("{0},{1},{2},{3}\r\n"
                    , ++index, a.Name, a.ID, a.PW)); 
            }
            StreamWriter sw = new StreamWriter(dir, false, Encoding.Default);
            sw.WriteLine(sb.ToString());
            sw.Close();
            sw.Dispose(); // 
            MessageBox.Show("저장되었습니다.");
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 백업ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Path.GetFileNameWithoutExtension(dir);
            string ext = Path.GetExtension(dir).Replace(".", "");

            // MyID_PW.txt.txt로 저장가능하도록
            string newDir =
                Path.Combine(Application.StartupPath,
                    String.Format("{0}{1}.{2}"
                        , name
                        , String.Format("{0}{1:0#}{2}"
                            , DateTime.Now.Year
                            , DateTime.Now.Month
                            , DateTime.Now.Day.ToString().PadLeft(2, '0')
                          )
                        , ext
                    )
                );

            if (File.Exists(dir))
            {
                File.Copy(dir, newDir, true); // 원본을 복사해서 백업
            }
        }

        private int currentIndex = -1;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            currentIndex = e.RowIndex;      
            DataGridViewCell dgvc = dataGridView.Rows[e.RowIndex].Cells[0];
            currentIndex = Convert.ToInt32(dgvc.Value.ToString())-1;         
            if (currentIndex != -1)
            {             
                ShowRecord(currentIndex);
            }
        }
        private void ShowRecord(int index)
        {
            this.txtNum.Text = (index + 1).ToString();
            this.txtName.Text = idpw[index].Name;
            this.txtID.Text = idpw[index].ID;
            this.txtPW.Text = idpw[index].PW;

            btnOK.Text = "추가";
        }      

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (currentIndex != -1 && blnModified==true)
            {
                //변경된 데이터로 idpw 개체의 현재 인덱스 데이터 변경
                idpw[currentIndex].Name = txtName.Text;
                idpw[currentIndex].ID = txtID.Text;
                idpw[currentIndex].PW = txtPW.Text;
                MessageBox.Show("수정되었습니다.","수정완료");
                DisplayData();//다시 로드
                
                blnModified = false;
            }                        
        }
         //3개 텍스트박스에서 TextChanged 이벤트 발생시 호출
         private bool blnModified = false;
         private void txtName_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (txtName.Text != "") //데이터가 로드된 상태에서만
             {
                 blnModified = true;  //변경되었다.
             }
         }
          private void btnDelete_Click(object sender, EventArgs e)
          {
              if (txtNum.Text != "" && currentIndex != -1) //현재상태
              {
                  DialogResult dr = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if (dr != DialogResult.No)
                  {
                      //메모리 상에서 현재 레코드 삭제
                      idpw.RemoveAt(currentIndex);
                      DisplayData();
                  }
              }
          }

          private void btnMove_Click(object sender, EventArgs e)
          {
              Button btn = sender as Button;
              if (btn == btnFirst)
              {
                  if (currentIndex > 0)
                  {
                      currentIndex = 0; //0번째 인덱스로 표시
                  }
              }
              else if (btn == btnPrev)
              {
                  if (currentIndex > 0)
                  {
                      currentIndex--;
                  }
              }
              else if (btn == btnNext)
              {
                  if (currentIndex < idpw.Count - 1)
                  {
                      currentIndex++;
                  }
              }
              else if (btn == btnLast)
              {
                  if (currentIndex != 1)
                  {
                      currentIndex = idpw.Count - 1;
                  }
              }
              ShowRecord(currentIndex);
          }

        

          private void btnSerch_Click(object sender, EventArgs e)
          {
              DisplayData(txtSerch.Text);
          }
    }
}
