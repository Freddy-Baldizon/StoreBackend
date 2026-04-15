using System;

namespace StoreBackend.Exceptions;

public class ResourceNotFoundExpception : Exception
{
  public ResourceNotFoundExpception() : base("Resource not found"){}
  public ResourceNotFoundExpception(string message) : base(message){}
}
