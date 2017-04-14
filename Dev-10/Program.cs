using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Dev_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileContents = new List<string>();
            string path = @"D:\config.json";
            FileReader fileReader = new FileReader();
            fileReader.GetFileContents(fileContents, path);
            //
            string key = "input";
            string value = String.Empty;
            int indexOfLine = 0;
            Parcer Parcer = new Parcer();
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            string pathInput = value;
            //
            key = "output";
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            string pathOutput = value;
            //
            fileReader.GetFileContents(fileContents, pathInput);
            //
            Rootobject shop = new Rootobject();
            key = "orderID";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            shop.orderID = Convert.ToInt32(value);
            key = "shopperName";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            shop.shopperName = value;
            key = "shopperEmail";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            shop.shopperEmail = value;
            //
            Content content1 = new Content();
            Content content2 = new Content();
            key = "productID";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            content1.productID = Convert.ToInt32(value);
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            content2.productID = Convert.ToInt32(value);
            //
            key = "productName";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            content1.productName = value;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            content2.productName = value;
            //
            key = "quantity";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            content1.quantity = Convert.ToInt32(value);
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            content2.quantity = Convert.ToInt32(value);
            //
            Content[] content = { content1, content2};
            shop.contents = content;
            //
            key = "orderCompleted";
            value = String.Empty;
            indexOfLine = 0;
            Parcer.FileTextToDictionary(ref indexOfLine, fileContents, key, out value);
            shop.orderCompleted = Convert.ToBoolean(value);

            //Outputer outputer = new Outputer();
            //outputer.Value(filesText, startIndexOfValue, endIndexOfValue);
        }
    }
}
