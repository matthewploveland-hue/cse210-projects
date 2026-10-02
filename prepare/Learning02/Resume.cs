public class Resume


{
        // The C# convention is to start member variables with an underscore _
        public string _name = "";
        public List<Job> _jobs = new List<Job>();
        


        

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public void DisplayResume()
    {   
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        
    }