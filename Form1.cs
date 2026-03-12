using System.Diagnostics;

namespace CS_Week01_25017084_MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 사진 클릭 시 동작 (현재 비어있음)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 레이블 클릭 시 동작 (현재 비어있음)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // 레이블 클릭 시 동작 (현재 비어있음)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 배경색 랜덤 변경을 위한 랜덤 객체 생성
            Random rd = new Random();
            // 0~255 사이의 색상 값을 조합하여 폼의 배경색으로 지정
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 지정된 GitHub 주소로 웹 브라우저를 실행 (UseShellExecute 옵션 필수)
            Process.Start(new ProcessStartInfo("https://github.com/dev-choiks") { UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 프로젝트 리소스에 등록한 'tkwls2' 이미지로 사진 변경
            pictureBox1.Image = Properties.Resources.tkwls2;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // 사진 클릭 이벤트 (추가 생성된 부분)
        }

        // 마우스가 사진 영역 안으로 들어올 때 테두리 생성
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // 경계선 스타일을 Fixed3D(입체감 있는 테두리)로 변경
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        // 마우스가 사진 영역 밖으로 나갈 때 테두리 제거
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // 경계선 스타일을 None(테두리 없음)으로 변경
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}