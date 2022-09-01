using System;

namespace project
{
    class Program
    {

        static void Main(string[] args)
        {

            main_menu main = new main_menu();
            main.d();     
        }
    }
    public class calculator//완성
    {
        public void a()
        {
          
            int a = 0;
            int sum = 0;
            string[] b= new string[100];
            string c;
            string d;
            int i = 0;
            main_menu main = new main_menu();
            calculator ca = new calculator();
            Console.WriteLine("계산기 기능을 선택 하셨습니다.");
            Console.WriteLine("덧셈는 +,뺄셈은 -,곱하기는 *,나누기는 /를 써서 \n계산식을 쓸 수 있습니다.");
            sum = Convert.ToInt32(Console.ReadLine());
            c = Console.ReadLine();
            b[i] = c;
            while (true)
            {
                
                a = Convert.ToInt32(Console.ReadLine());
                c = Console.ReadLine();
                b[i] = c;
                if (b[i] == "+")
                    sum += a;
                else if (b[i] == "-")
                    sum -= a;
                else if (b[i] == "*")
                    sum *= a;
                else if (b[i] == "/")
                    sum /= a;
                else if (b[i] == "=")
                {
                    if(i!=1)
                    {
                        if (b[i - 1] == "+")
                            sum += a;
                        else if (b[i - 1] == "-")
                            sum -= a;
                        else if (b[i - 1] == "*")
                            sum *= a;
                        else if (b[i - 1] == "/")
                            sum /= a;
                    }
                    Console.WriteLine(sum);
                    Console.WriteLine("계산을 계속 하시겠습니끼?(Y/N)");
                    d=Console.ReadLine();
                    if (d == "Y" || d == "y")
                    {
                        ca.a();
                    }
                    else
                        main.d();

                }
                i++;
            }
        }
    }
    public class help//완성
    {
        string h;
        public void b()
        {
            main_menu main = new main_menu();
            while (true)
            {
                Console.WriteLine("어떤 도움이 필요하신가요?\n계산기 도움말이 필요하시면 C,\n문제 도움말이 필요하시면 Q를 눌러주세요.");
                Console.WriteLine("메인메뉴로 돌아가시려면 M을 눌러주세요.");
                h = Console.ReadLine();
                if (h == "C" || h == "c")
                {
                    Console.WriteLine("계산기는 더하기,뺄셈,곱셈,나누기를 할 수 있습니다.\n" +
                        "숫자를 입력한 후,기호를 입력하여 식을 쓸 수 있습니다.\n" +
                        "식의 결과를 보고싶다면 기호를 입력할 차례에 =를 입력하여 볼 수 있습니다. ");
                }
                else if (h == "Q" || h == "q")
                {
                    Console.WriteLine("문제는 난이도가 총 3개로 나누어져 있으며,\n총 10 문제를 푼 후, 맞은 개수와 틀린 개수를 확인 할 수 있습니다.");
                }
                if (h == "M" || h == "m")
                    main.d();

            }

        }
    }
    public class qize//완성
    {
        public void c()
        {
            
            string q;
            int an=0;
            int d=0;
            string an1;
            main_menu main = new main_menu();
            qize qi = new qize();

            Console.WriteLine("난이도를 선택해주세요.\n" +
                "쉬움:1 보통:2 어려움:3");
            q=Console.ReadLine();
            if(q=="1")
            {
                Console.WriteLine("쉬움 난이도 를 선택하셨습니다.");
                Console.WriteLine("1.(산수 문제)8*X=56이다. 이때,X는 몇인가?");
                an=Convert.ToInt32( Console.ReadLine());
                if (an == 8)
                    d++;
                Console.WriteLine("2.(넌센스 문제)아침엔 네발,점심엔 두발,저녁에 세발인 것은?");
                an1 = Console.ReadLine();
                if (an1 == "인간")
                    d++;
                Console.WriteLine("3.(과학 문제)H+H+O=?(정답을 적을 때 ₂같은 작은 숫자는 큰 숫자로 적음.");
                an1 = Console.ReadLine();
                if (an1 == "H2O") 
                    d++;
                Console.WriteLine("4.(산수 문제)12를 3으로 나눈다면 무슨 수가 나오는가?");
                an = Convert.ToInt32(Console.ReadLine());
                if (an == 4)
                    d++;
                Console.WriteLine("2.(역사 문제)3.1절은 어떤 사건을 기념하는 날이다. 이때 어떤 사건은 무엇인가 ?");
                an1 = Console.ReadLine();
                if (an1 == "3.1 운동"||an1=="3.1만세 운동")
                    d++;
                Console.WriteLine("맞은 개수:" + d);
                Console.WriteLine("틀린 개수:" + (5-d));
                Console.WriteLine("문제를 더 푸실 건가요?(Y/N)");
                an1 = Console.ReadLine();
                if (an1 == "Y" || an1 == "y")
                    qi.c();
                else
                    main.d();
            }
            else if(q=="2")
            {
                Console.WriteLine("보통 난이도 를 선택하셨습니다.");
                Console.WriteLine("1.(역사 문제)임진왜란이 일어난 년도는?");
                an = Convert.ToInt32(Console.ReadLine());
                if (an == 1592)
                    d++;
                Console.WriteLine("2.(상식 문제)사흘은 며칠인가?(일은 생략하여 답을 쓴다)");
                an = Convert.ToInt32(Console.ReadLine());
                if (an == 3)
                    d++;
                Console.WriteLine("3.(역사 문제)을사늑약에 동의한 5명을 칭하는 말은?");
                an1 = Console.ReadLine();
                if (an1 == "을사오적")
                    d++;
                Console.WriteLine("4.(과학 문제)토끼는 발바닥에 육구(발바닥 젤리)가 있다?(O/X)");
                an1 = Console.ReadLine();
                if (an1 == "X"||an1=="x")
                    d++;
                Console.WriteLine("5.(과학 문제)사람을 가장 많이 공격한 해양생물은 상어다?(O/X)");
                an1 = Console.ReadLine();
                if (an1 == "X" || an1 == "x")
                    d++;
                Console.WriteLine("맞은 개수:" + d);
                Console.WriteLine("틀린 개수:" + (5 - d));
                Console.WriteLine("문제를 더 푸실 건가요?(Y/N)");
                an1 = Console.ReadLine();
                if (an1 == "Y" || an1 == "y")
                    qi.c();
                else
                    main.d();
            }
            else if(q=="3")
            {
                Console.WriteLine("어려움 난이도 를 선택하셨습니다.");
                Console.WriteLine("1.(과학 문제)원소번호 100번은 무엇인가?");
                an1 = Console.ReadLine();
                if (an1 == "Fm")
                    d++;
                Console.WriteLine("2.(코딩 문제)int 는 8바이트 이다?(O/X)");
                an1 = Console.ReadLine();
                if (an1 == "X" || an1 == "x")
                    d++;
                Console.WriteLine("3.(상식 문제)강아지는 발바닥에서만 땀이 난다?(O/X)");
                an1 = Console.ReadLine();
                if (an1 == "O" || an1 == "o")
                    d++;
                Console.WriteLine("4.(지리 문제)전세계 국가수는 208개이다?(O/X)");
                an1 = Console.ReadLine();
                if (an1 == "O" || an1 == "o")
                    d++;
                Console.WriteLine("5.(과학 문제)게르마늄의 원소기호는?");
                an1 = Console.ReadLine();
                if (an1 == "Ge")
                    d++;
            }
        }
    }
    public class main_menu//완성
    {
        public void d()
        {
            string m;
            Console.WriteLine("환 메인메뉴 영\n도움말 H\n문제 Q\n계산기 C");
            calculator ca = new calculator();
            help he = new help();
            qize qi = new qize();
            m = Console.ReadLine();
            if (m == "C" || m == "c")
                ca.a();
            if (m == "H" || m == "h")
                he.b();
            if (m == "Q" || m == "q")
                qi.c();
        }
            
    }
}
