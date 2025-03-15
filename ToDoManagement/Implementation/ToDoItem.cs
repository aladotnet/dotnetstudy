using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManagement.Implementation;

public class ToDoItem
{
}


public class Caculator
{
    public int Calculate(int a , int b)
    { 
        var result = a + b;
        return result;
    }
}

/*
// arrange
vaue a   1
value b   2
value c   3

// act
Calculate(a,b) 

// check
produces  c
 */