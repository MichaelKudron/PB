using AiSDZad1;

try
{
    using (StreamReader sr = new StreamReader("./in.txt"))
    {
        using (StreamWriter sw = new StreamWriter("./out.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                newtonv1 Newton1 = new newtonv1();
                NewtonProduction Newton2 = new NewtonProduction();
                string[] strings = line.Split(' ').ToArray();
                sw.WriteLine(Newton1.count(int.Parse(strings[0]), int.Parse(strings[1])) + " " + Newton1.counter);
                sw.WriteLine(Newton2.count(int.Parse(strings[0]), int.Parse(strings[1])) + " " + Newton2.counter);
            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}