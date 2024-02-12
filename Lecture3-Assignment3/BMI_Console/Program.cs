double BMI(String I, String P)
{
    Double bmi, inch, weight;
    inch = Convert.ToDouble(I);
    weight = Convert.ToDouble(P);
    bmi = weight / (inch * inch) * 703;
    return bmi;
}

bool correct = false;
string gender;
double height = 0;
double weight = 0;
int age = 0;


do
{
    Console.WriteLine("Enter your gender: m/f");
    gender = Console.ReadLine();

    switch (gender)
    {
        case "m":
        case "f":
            correct = true;
            break;
    }

}
while (!correct);

do
{
    Console.WriteLine("Enter your height in inches: ");
    try
    {
        height = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
    }
}
while (height <= 0);


do
{
    Console.WriteLine("Enter your weight in pounds: ");
    try
    {
        weight = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
    }
}
while (weight <= 0);

do
{
    Console.WriteLine("Enter your age: ");
    try
    {
        age = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
    }
}
while (weight <= 0);


double bmi = (weight / (height * height) * 703);
string health;

if (age > 15)
{
    if (bmi < 18.5)
    {
        health = "Underweight";
    }
    else if (bmi >= 25 && bmi < 25)
    {
        health = "Healthy";
    }
    else if (bmi >= 25 && bmi < 30)
    {
        health = "Overweight";
    }
    else
    {
        health = "Obese";
    }
}
else
{
    if (gender == "m")
    {
        if (bmi < 14.2)
        {
            health = "Underweight";
        }
        else if (bmi >= 14.2 && bmi < 19.4)
        {
            health = "Healthy";
        }
        else if (bmi >= 19.4 && bmi < 22)
        {
            health = "Overweight";
        }
        else
        {
            health = "Obese";
        }
    }
    else
    {
        if (bmi < 14)
        {
            health = "Underweight";
        }
        else if (bmi >= 14 && bmi < 19.5)
        {
            health = "Healthy";
        }
        else if (bmi >= 19.5 && bmi < 22.5)
        {
            health = "Overweight";
        }
        else
        {
            health = "Obese";
        }
    }
}


Console.WriteLine("Your BMI is: " + bmi + " / " + health);