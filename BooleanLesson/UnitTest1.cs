using System.Collections.Generic;
using Xunit;
using BooleanLesson;

namespace BooleanLesson;

public class UnitTest1
{
    [Fact]
    public void TestIsFirstNumberBigger()
    {
        Assert.True(BooleanLesson1.IsFirstNumberBigger(2, 1));
        Assert.True(BooleanLesson1.IsFirstNumberBigger(2000, -10));
        Assert.False(BooleanLesson1.IsFirstNumberBigger(0, 1));
        Assert.False(BooleanLesson1.IsFirstNumberBigger(0, 0));
    }

    [Fact]
    public void TestIsNumberEven()
    {
        Assert.True(BooleanLesson1.IsNumberEven(2));
        Assert.True(BooleanLesson1.IsNumberEven(8));
        Assert.True(BooleanLesson1.IsNumberEven(0));
        Assert.False(BooleanLesson1.IsNumberEven(1));
        Assert.False(BooleanLesson1.IsNumberEven(3));
    }

    [Fact]
    public void TestIsNumberInRange()
    {
        Assert.True(BooleanLesson1.IsNumberInRange(1, 0, 2));
        Assert.True(BooleanLesson1.IsNumberInRange(5, -5, 5));
        Assert.True(BooleanLesson1.IsNumberInRange(1, 1, 1));
        Assert.False(BooleanLesson1.IsNumberInRange(-10, -5, 5));
        Assert.False(BooleanLesson1.IsNumberInRange(0, 5, 10));
    }

    [Fact]
    public void TestIsNumberOutsideRange()
    {
        Assert.False(BooleanLesson1.IsNumberOutsideRange(1, 0, 2));
        Assert.False(BooleanLesson1.IsNumberOutsideRange(5, -5, 5));
        Assert.False(BooleanLesson1.IsNumberOutsideRange(1, 1, 1));
        Assert.True(BooleanLesson1.IsNumberOutsideRange(-10, -5, 5));
        Assert.True(BooleanLesson1.IsNumberOutsideRange(0, 5, 10));
    }

    [Fact]
    public void TestCanPersonBuyDrink()
    {
        var person = new Person(10, 3f);
        Assert.True(BooleanLesson1.CanPersonBuyDrink(person, new Drink(1, false)));
        Assert.False(BooleanLesson1.CanPersonBuyDrink(person, new Drink(4, false)));
        Assert.False(BooleanLesson1.CanPersonBuyDrink(person, new Drink(2, true)));

        var person2 = new Person(27, 1f);
        Assert.True(BooleanLesson1.CanPersonBuyDrink(person2, new Drink(1, false)));
        Assert.True(BooleanLesson1.CanPersonBuyDrink(person2, new Drink(1, true)));
        Assert.False(BooleanLesson1.CanPersonBuyDrink(person2, new Drink(2, true)));
    }

    [Fact]
    public void TestIsWeatherGood()
    {
        Assert.True(BooleanLesson1.IsWeatherGood(new Weather(25, 10, false)));
        Assert.True(BooleanLesson1.IsWeatherGood(new Weather(22, 0, false)));
        Assert.False(BooleanLesson1.IsWeatherGood(new Weather(25, 10, true)));
        Assert.False(BooleanLesson1.IsWeatherGood(new Weather(25, 120, false)));
        Assert.False(BooleanLesson1.IsWeatherGood(new Weather(50, 0, false)));
        Assert.False(BooleanLesson1.IsWeatherGood(new Weather(-20, 0, false)));
        Assert.False(BooleanLesson1.IsWeatherGood(new Weather(90, 150, true)));
    }

    [Fact]
    public void TestWeatherThisWeek()
    {
        var weathers = new[]
        {
            new Weather(25, 0, false),
            new Weather(25, 0, false),
            new Weather(25, 0, false),
            new Weather(25, 0, false),
            new Weather(25, 0, false),
            new Weather(25, 0, false),
            new Weather(25, 0, false),
        };

        Assert.True(BooleanLesson1.IsWeatherGoodEveryDayOfTheWeek(weathers));

        weathers[0] = new Weather(50, 150, true);
        
        Assert.False(BooleanLesson1.IsWeatherGoodEveryDayOfTheWeek(weathers));
    }

    [Fact]
    public void TestCanPersonBuyAllDrinks()
    {
        var oldPerson = new Person(21, 12f);
        var youngPerson = new Person(2, 8f);
        
        List<Drink> drinks = new()
        {
            new Drink(1, false),
            new Drink(3, true)
        };
        
        Assert.True(BooleanLesson1.CanPersonBuyAllDrinks(oldPerson, drinks.ToArray()));
        Assert.False(BooleanLesson1.CanPersonBuyAllDrinks(youngPerson, drinks.ToArray()));
        
        drinks.Add(new Drink(5, true));
        drinks.Add(new Drink(5, true));
        
        Assert.False(BooleanLesson1.CanPersonBuyAllDrinks(oldPerson, drinks.ToArray()));
    }

    [Fact]
    public void TestIsAnyNumberEven()
    {
        Assert.True(BooleanLesson1.AnyNumberIsEven(new[]{2,4,6}));
        Assert.True(BooleanLesson1.AnyNumberIsEven(new[]{1,3,6}));
        Assert.True(BooleanLesson1.AnyNumberIsEven(new[]{0,1,1}));
        Assert.False(BooleanLesson1.AnyNumberIsEven(new[]{3,5,7}));
        Assert.False(BooleanLesson1.AnyNumberIsEven(new[]{3}));
    }
}
        