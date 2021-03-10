using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPratice
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();
            Video video = new Video();
            Mail mail = new Mail();
            encoder.VideoEncoded += mail.onEncoded;
            encoder.Encoded(video);

            encoder.VideoEncoded -= mail.onEncoded;
            Fax fax = new Fax();
            encoder.VideoEncoded += fax.onEncoded;
            encoder.Encoded(video);
            Console.ReadLine();

        }
    }
}
