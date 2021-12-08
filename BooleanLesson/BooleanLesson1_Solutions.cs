using System.Linq;
using BooleanLesson;

namespace BooleanLessonSolutions;

public static class BooleanLesson1
{
    public static bool IsFirstNumberBigger(int firstNumber, int secondNumber)
    {
        return firstNumber > secondNumber;
    }
    
    public static bool IsNumberEven(int number)
    {
        return number % 2 == 0;
    }
    
    // Min and Max Inclusive
    public static bool IsNumberInRange(int number, int min, int max)
    {
        return number >= min && number <= max;
    }
    
    public static bool IsNumberOutsideRange(int number, int min, int max)
    {
        return !IsNumberInRange(number, min, max);
    }
    
    public static bool AnyNumberOfThreeIsEven(int firstNumber, int secondNumber, int thirdNumber)
    {
        return IsNumberEven(firstNumber) || IsNumberEven(secondNumber) || IsNumberEven(thirdNumber);
    }
    
    public static bool CanPersonBuyDrink(Person person, Drink drink)
    {
        if (drink.IsAlcoholic && person.Age < 18)
        {
            return false;
        }

        return person.MoneyInEuro >= drink.PriceInEuro;
    }
    
    public static bool IsWeatherGood(Weather weather)
    {
        if (weather.IsRaining) return false;
        
        return IsNumberInRange(weather.TemperatureInCelcius, 15, 40) &&
               IsNumberInRange(weather.WindSpeedInKmh, 0, 50);
    }

    
    public static bool IsWeatherGoodEveryDayOfTheWeek(Weather[] weatherThisWeek)
    {
        bool weatherIsGood = true;
        
        foreach (var weather in weatherThisWeek)
        {
            weatherIsGood &= IsWeatherGood(weather);
        }

        return weatherIsGood;
    }

    public static bool CanPersonBuyAllDrinks(Person person, Drink[] drinks)
    {
        foreach (var drink in drinks)
        {
            if (CanPersonBuyDrink(person, drink))
            {
                person.MoneyInEuro -= drink.PriceInEuro;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
    
    public static bool AnyNumberIsEven(int[] numbers)
    {
        return numbers.Any(IsNumberEven);
    }
    
    public static string GetLongerString(string firstString, string secondString)
    {
        return firstString.Length > secondString.Length ? firstString : secondString;
    }
}