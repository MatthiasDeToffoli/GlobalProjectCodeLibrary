# GlobalProjectCodeLibrary
Library for C# projects, it's some classes I create all the time, when I work in new projects I made a library for use them more easily

## Interfaces
### ISingleton

It's an interface defined singletons, it has an unique Id, a method for remove the instance of the singleton and another one for replace it.

### IManager

Used for my managers, it has the method Init which will be used for initialize managers and control when they will be. And another clear for clear the managers.

## Classes

### ASingleton

Abstract class reprensenting singletons it take a parameter T wich have to be your singleton. 

```C#
public class MySingleton:ASingleton<MySingleton>
```

it implement ISingleton interface. It create the instance at the first call of the property instance and set the unique Id in its constructor. This unique Id is set to empty string when the instance is removed.

___

*<sub>Made with .Net Standard 2.1</sub>*
