using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Music_scholarship_quiz
{
    class File_Control
    {
        
        //파일 경로
        public string Get_active_program()
        {
            string path = Directory.GetCurrentDirectory();

            return path;
        }

        //해당 스코어의 파일 List 가지고 오기
        public string[] file_list(string year, string score)
        {
            string path = Get_active_program() + @"\음악\" + year + @"\" + score;
            string[] file_list = { };
            
            try
            {
                file_list = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            }catch(Exception err)
            {
                path = err.ToString();
            }

            return file_list;
        }

        //파일 이동
        public string file_move(string old_path)
        {
            string path = Get_active_program() + @"\Play";
            string file_name = Path.GetFileName(old_path);
            path = path + @"\" + file_name;
            File.Move(old_path, path);
            return path;
        }


        //파일 Count
        public int file_count(string year, string score)
        {
            string path = Get_active_program() + @"\음악\" + year + @"\" + score;
            int count = 0;

            try
            {
                if (Directory.Exists(path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(path);
                    count = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories).Length;
                }
            }catch(Exception err)
            {
                path = err.ToString();
            }

            return count;
        }
    }
}
