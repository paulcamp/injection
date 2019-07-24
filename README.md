# injection / dependency injection / inversion of control 

A demonstration of "inversion of control"

The MVC "EmptyController" class needs an "IStockEngine".  

We use a DI Container, in this example "Unity" to resolve what "IStockEngine" is at run-time.  


## Unit Testing


Here we use Moq to create a Mock<IStockEngine> and setup what we want to return when its method "LookupItem" is called.  
Mocking allows us to isolate things away from what we are trying to test. In this example, the StockEngine in the real world could call a database, thats not something you'd want to be doing in a unit test! What we really test here is that the dicount logic is working, we dont care how the StockEngine has been implemented.
  

  

