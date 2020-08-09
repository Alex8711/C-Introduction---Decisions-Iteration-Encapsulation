using System;
using System.Linq;
using System.Collections;

namespace Arrays_and_Basic_Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new ArrayList(){
            "Alex","Bob","Sophie","Rex","Kate","Jim","Tom"
            };
            DisplayNameList(nameList);

            System.Console.WriteLine("Do you want to delete or update the list? if you want to delete, please input 'delete'.if you want to update, please input 'update'.");
            String input_1 = Console.ReadLine().ToLower();
            if (input_1.Equals("delete"))
            {
                System.Console.WriteLine("Do you want delete via name or index number? please input 'name' or 'index'?");
                String input_2 = Console.ReadLine().ToLower();
                if (input_2.Equals("name"))
                {
                    System.Console.WriteLine("Please input name you want to delete");
                    String input_3 = Console.ReadLine().ToLower().Trim();
                    input_3 = input_3.First().ToString().ToUpper() + input_3.Substring(1);
                    DeleteViaName(nameList, input_3);
                    // DisplayNameList(nameList);
                }
                else if (input_2.Equals("index"))
                {
                    System.Console.WriteLine("Please input the index number of name you want to delete");
                    int indexDelete = int.Parse(Console.ReadLine());
                    DeleteViaIndex(nameList, indexDelete);
                }
                else
                {
                    System.Console.WriteLine("Please input valid command");
                }
            }
            else if (input_1.Equals("update"))
            {
                System.Console.WriteLine("Do you want to update via name or index number? please input 'name' or 'index'?");
                String input_2 = Console.ReadLine().ToLower();
                if (input_2.Equals("name"))
                {
                    System.Console.WriteLine("Please input name you want to update");
                    String input_3 = Console.ReadLine().ToLower().Trim();
                    input_3 = input_3.First().ToString().ToUpper() + input_3.Substring(1);
                    System.Console.WriteLine("Please input your update");
                    String input_4 = Console.ReadLine().ToLower().Trim();
                    input_4 = input_4.First().ToString().ToUpper() + input_4.Substring(1);
                    while (input_4.Contains(' ') || input_4.Length < 2 || nameList.Contains(input_4))
                    {
                        System.Console.WriteLine("Please input your Valid update");
                        input_4 = Console.ReadLine().ToLower().Trim();
                        input_4 = input_4.First().ToString().ToUpper() + input_4.Substring(1);
                    }
                    UpdateViaName(nameList, input_3, input_4);



                }
                else if (input_2.Equals("index"))
                {
                    System.Console.WriteLine("Please input the index number of name you want to update");
                    int indexDelete = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Please input your update");
                    String input_4 = Console.ReadLine().ToLower().Trim();
                    input_4 = input_4.First().ToString().ToUpper() + input_4.Substring(1);
                    while (input_4.Contains(' ') || input_4.Length < 2 || nameList.Contains(input_4))
                    {
                        System.Console.WriteLine("Please input your Valid update");
                        input_4 = Console.ReadLine().ToLower().Trim();
                        input_4 = input_4.First().ToString().ToUpper() + input_4.Substring(1);
                    }
                    UpdateViaIndex(nameList, indexDelete, input_4);

                }
                else
                {
                    System.Console.WriteLine("Please input valid command");
                }

            }
            else
            {
                System.Console.WriteLine("Please input valid command");
            }
            Console.ReadKey();
        }
        public static void DisplayNameList(ArrayList nameList)
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                System.Console.WriteLine(nameList[i] + " --" + (i + 1));
            }
        }
        public static void DeleteViaName(ArrayList nameList, String name)
        {
            nameList.Remove(name);
            for (int i = 0; i < nameList.Count; i++)
            {
                System.Console.WriteLine(nameList[i] + " --" + (i + 1));
            }
        }
        public static void DeleteViaIndex(ArrayList nameList, int index)
        {
            nameList.RemoveAt(index - 1);
            for (int i = 0; i < nameList.Count; i++)
            {
                System.Console.WriteLine(nameList[i] + " --" + (i + 1));
            }
        }
        public static void UpdateViaName(ArrayList nameList, String name, String update)
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                if (nameList[i].Equals(name))
                {
                    nameList[i] = update;
                }
            }
            for (int i = 0; i < nameList.Count; i++)
            {
                System.Console.WriteLine(nameList[i] + " --" + (i + 1));
            }
        }
        public static void UpdateViaIndex(ArrayList nameList, int index, String update)
        {
            nameList[index - 1] = update;
            for (int i = 0; i < nameList.Count; i++)
            {
                System.Console.WriteLine(nameList[i] + " --" + (i + 1));
            }
        }
    }
}
