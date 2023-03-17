using System.Xml.Schema;

namespace DangVuLinh
{

    //1.Tạo một interface tên IStudent bao gồm các properties và methods: (Total: 4 points)
    //a.Properties
    //i.StudID(int) – (0.5 points)
    //ii.StudName(string) – (0.5 points)
    //iii.StudGender(string) – (0.5 points)
    //iv.StudAge(int) – (0.5 points)
    //v.StudClass(string) – (0.5 points)
    //vi.StudAvgMark(float) - Read only property – (1.0 points)
    //b.Methods
    //i. void Print(); -(0.5 points)

    public interface IStudent
    {

        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; }

        public void Print();
    }

    //2.Tạo một class tên Student(Total: 6 point)
    //a.Triển khai(implement) inteface Istudent ở bước 1 (2.0 points)
    //b.Method Print() sẽ hiển StudID, StudName, StudGender, StudAge, StudClass
    //và StudAvgMark của student trên console. (1.0 points)
    //c.Khai báo mảng MarkList kiểu int kích thước 3 (0.5 points).
    //d.Tạo indexer sử dụng MarkList trong bước 2c (1.5 points).
    ////e.Tạo method CalAvg đẻ gán giá trị StudAvgMar k bằng trung bình cộng của các
    //phần tử trong mảng MarkList. (1.0 points)
    public class Student : IStudent
    {
        public void Print()
        {
            Console.WriteLine("***Thong tin sv***");
            Console.WriteLine("ID: {0} \tName: {1} \tGender: {2} \tAge: {3} \tClass: {4} \tAvgMark: {5}", StudID, StudName, StudGender, StudAge, StudClass, Student.CalAvg());
        }

        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        public float Mark3 { get; set; }


        public float StudAvgMark { get; }

        int[] MarkList = new int[3];

        public int this[int i]
        {
            get { return MarkList[i]; }
            set { MarkList[i] = value; }
        }
        void CalAvg()
        {
            float StudAvgMar;
            float total = 0;
            for (int i=0; i<MarkList.Length; i++)
            {
                 total += MarkList[i];
            }
            StudAvgMar = total / MarkList.Length;
        }



        //    . Nếu chọn 1: (Total : 7.0 points)
        //a.Tạo một student mới rồi nhập vào StudID, StudName, StudGender, StudAge,
        //StudClass sau đó yêu cầu nhập vào 3 mark và thêm student đó vào indexer. (4.0
        //points)
        //b.Tạo Hastable(sử dụng chỉ 1 Hastable) để lưu Students trong bước a với key =
        //StudID và value là student. (3.0 points)
                public void TaoSV()
        {
            Student sv = new Student();
            Console.Write("Nhap id sv: ");
            sv.StudID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten sv: ");
            sv.StudName = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap gioi tinh sv: ");
            sv.StudGender = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap tuoi sv: ");
            sv.StudAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap lop sv: ");
            sv.StudClass = Convert.ToString(Console.ReadLine());
            Console.Write("nhap diem mon 1: ");
            sv.Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap diem mon 2: ");
            sv.Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap diem mon 3: ");
            sv.Mark3 = Convert.ToInt32(Console.ReadLine());
            sv.Print();

        }

    }

    //Tạp menu để chọn(Figure.1) (Total : 1.0 points
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Insert new Student...");
            Console.WriteLine("2. Display all the student list...");
            Console.WriteLine("3. Caculator average mark...");
            Console.WriteLine("4. Tim kiem student");
            Console.WriteLine("5. Exit.");
            Console.WriteLine("================================");
            Console.Write("Option: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("Them Sinh Vien");
                    student.TaoSV();
                    break;
                case 5:
                    Console.WriteLine("Thoat chuong trinh");
                    return;
            }
        }
    }
}