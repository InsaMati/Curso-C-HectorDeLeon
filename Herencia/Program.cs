Doctor doc = new Doctor("Matias",25,"Dermatologo");

Console.WriteLine(doc.GetData());
Console.WriteLine(doc.GetInfo());

Dev developer = new Dev("Matias", 25, "C#");
Console.WriteLine(developer.GetLanguage());

class People 
{
    private string _name;
    private int _age;
    public People(string name, int age) {

        _name = name;
        _age = age;
    
    }

    public string GetInfo() {

        return _name + " " + _age;
    }

}

class Doctor : People {

    private string _speciality;
    public Doctor(string name,int age,string speciality) : base(name,age) {

        _speciality = speciality;    
    }

    public string GetData() {
     
        return GetInfo() + " " + _speciality;
    }

}

class Dev : People
{
    private string _language;

    public Dev(string name, int age, string language) : base(name, age) {

        _language = language;

    }

    public string GetLanguage() {

        return GetInfo() + " " + _language;
    }
}