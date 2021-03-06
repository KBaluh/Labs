﻿using System;
using System.IO;

namespace FileData
{
    public abstract class DataManager
    {
        protected string FilePath { get; set; }

        public DataManager(string filePath)
        {
            FilePath = filePath;
        }

        public void Write()
        {
            string filePath = FilePath;
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read))
            {
                //создаём объект BinaryWriter для записи
                //простых типов данных в поток
                BinaryWriter bw = new BinaryWriter(fs);

                //вызовем перегрузку метода для записи данных в поток
                OnWrite(bw);

                //сохраним данные из буфера на диск
                bw.Flush();

                //WriteDebug(fs);
            }
        }

        protected abstract void OnWrite(BinaryWriter bw);

        public void Read()
        {
            string filePath = FilePath;
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read))
            {
                //прочитаем данные из файла
                BinaryReader br = new BinaryReader(fs);
                while (true)
                {
                    try
                    {
                        OnRead(br);
                    }
                    catch
                    {
                        Console.WriteLine("****************");
                        break;
                    }
                }
            }
        }

        protected abstract void OnRead(BinaryReader br);

        private void WriteDebug(FileStream fs)
        {
            //установим курсор на начало файла
            fs.Seek(0, SeekOrigin.Begin);

            //прочитаем данные из файла
            BinaryReader br = new BinaryReader(fs);

            //данные читать нужно в том же порядке,
            //в котором они и записывались в поток
            while (true)
            {
                try
                {
                    Console.Write(br.ReadString() + " = ");
                    Console.WriteLine(br.ReadDecimal());
                }
                catch
                {
                    Console.WriteLine("****************");
                    break;
                }
            }
        }
    }
}
