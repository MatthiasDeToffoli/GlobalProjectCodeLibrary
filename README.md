# GlobalProjectCodeLibrary
Library for C# projects, it's some classes I create all the time, when I work in new projects I made a library for use them more easily

## Interfaces
### ISingleton

It's an interface  used only to type the singletons in the class ASingleton, it not implement methods or properties.

### IManager

Used for my managers, it has the method Init wich will be used for initialize my managers and control when they will be.

## Classes

### ASingleton

Abstract class reprensenting singletons it take a parameter T wich have to be your singleton, it implement ISingleton interface. It create the instance at the first call of the property instance.
