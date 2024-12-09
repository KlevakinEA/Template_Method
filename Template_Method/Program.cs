StudentReportGenerator s = new StudentReportGenerator();
GroupReportGenerator g = new GroupReportGenerator();
s.Export(s.Form(s.Compute(s.Collect())));
g.Export(g.Form(g.Compute(g.Collect())));




abstract class ReportGenerator
{
    abstract public string Collect();
    abstract public string Compute(string input);
    abstract public string Form(string input);
    public void Export(string input) { Console.WriteLine(input); }
}


class StudentReportGenerator: ReportGenerator
{
    override public string Collect() { Console.WriteLine("Data collected"); return "Data"; }
    override public string Compute(string input) { Console.WriteLine("Data computed"); return input + "_"; }
    override public string Form(string input) { Console.WriteLine("Data Formed"); return input + "."; }
}


class GroupReportGenerator : ReportGenerator
{
    override public string Collect() { Console.WriteLine("Data collected"); return "Other data"; }
    override public string Compute(string input) { Console.WriteLine("Data computed"); return input + " "; }
    override public string Form(string input) { Console.WriteLine("Data Formed"); return input + ","; }
}