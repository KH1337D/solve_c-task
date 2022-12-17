using System;

namespace objectOriented{

    public  class person{
   
    public string name ;
    public int age ;
    public person(string name , int age) {


     //Name = name;
     //Age = age;
      

    }
    

    public override void Print(){

      Console.WriteLine($"My name is {name}, my age is {age}");


    }
   
   }

    public class  student : person
    {
      int year;
      float Gpa;
      public student(string name , int age ,int year , float Gpa ):base(name, age){
        
        
       // Year = year;
        //Gpa = gpa;

      }
       
       public override void Print(){

        Console.WriteLine("My name is " + name + ", my age is " + age + " and my gpa is " + Gpa);
       }

      }
      public class DataBase
      {
       public person[] people = new person[20];
        
      }

      public class staff : person
      {
        double salary;
        int joinyear;
        public staff(string name,int age,double salary,int joinYear): base(name,age){


       // Salary = salary;
       //JoinYear = joinYear

        }

        public override void Print(){
          
          Console.WriteLine($"My name is {name}, my age is {age}, and my salary is {salary}");
        }
      }

    
       public class program {
                
                
         public static void Main(string[] args){

          
        //DataBase info = new DataBase();
         DataBase database = new DataBase();
        
          Console.ReadLine();    
      
          }
  
    }
    }
    
   