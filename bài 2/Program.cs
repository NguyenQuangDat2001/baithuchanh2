using System;

namespace bai_2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0;
            ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void nhap()
        {
            Console.Write("nhap tu so :"); ts = int.Parse(Console.ReadLine());
            Console.Write("nhap mau so :"); ms = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            if (ms == 1)
                Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }
        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Tich(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS thuong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t;
        }
    }
    class APP
    {
        static void Main()
        {
            PS t1 = new PS();
            Console.WriteLine(" nhap phan so t1");
            t1.nhap();
            t1.hien();
            PS t2 = new PS();
            Console.WriteLine(" nhap phan so t2");
            t2.nhap(); t2.hien();
            Console.WriteLine("Tong hai phan so......");
            PS t = t1.Tong(t2);
            t.hien();
            Console.WriteLine("hieu hai phan so.......");
            PS h = t1.hieu(t2);
            h.hien();
            Console.WriteLine("tich hai phan so .......");
            PS f = t1.Tich(t2);
            f.hien();
            Console.WriteLine("thuong hai phan so......");
            PS Y = t1.thuong(t2);
            Y.hien();

        }
    }
}

