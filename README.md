# GlobalProjectCodeLibrary
Library for C# projects, it's some classes I create all the time, when I work in new projects I made a library for use them more easily

## Interfaces
### ISingleton

It's an interface defined singletons, it has an unique Id, a method for remove the instance of the singleton and another one for replace it.

### IManager

Used for my managers, it has the method Init which will be used for initialize managers and control when they will be. And another clear for clear the managers.

### Pooling
#### IPoolManager
Interface of the Manager used for interact with the pool, has a function for create the pool,one for get an element of the pool and one for stock an element in the pool.

#### PoolElements
##### IPoolElement
Element used for create the element keep in the pool, it contain an ID, the number of element to create, the element to create itself and functions for compare and reset an element.

##### IPoolElementWithType
IPoolElement with a specific type, it can get the value with it good type.

```C#
/// it's a pool element used for create int
public class MyIntPoolElement:IPoolElementWithType<Int>
```

## Classes

### ASingleton

Abstract class reprensenting singletons it take a parameter T wich have to be your singleton. 

```C#
public class MySingleton:ASingleton<MySingleton>
```

it implement ISingleton interface. It create the instance at the first call of the property instance and set the unique Id in its constructor. This unique Id is set to empty string when the instance is removed.

### Pooling
#### APoolContainer
Abstract Parent of the containers used with pooling, has functions Add, Contain, Get, GetInternal (which has to be override in childrens) and Clear.

#### APoolInitializerContainer
Abstract class which initialize the pool

#### PoolContainer
Container used for create and managed pool elements on the current execution.
___

*<sub>Made with .Net Standard 2.1</sub>*
