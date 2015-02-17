using Core.Enums;
using System;
using System.ServiceModel;

namespace Redify45
{

    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        [OperationContract]
        long FibonacciNumber(long n);


        [OperationContract]
        Guid WhatIsYourToken();

        [FaultContract(typeof(ArgumentNullException))]
        [OperationContract]
        string ReverseWords(string s);


        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
    }
}
