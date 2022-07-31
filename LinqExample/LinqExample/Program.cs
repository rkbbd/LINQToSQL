

using LinqExample;

SchoolContext schoolContext = new SchoolContext();

schoolContext.AddAsync(new Student() { Name = "ABC" });
schoolContext.SaveChanges();

//var school = schoolContext.Students.Where(x => x.Id == 1).ToList(); 

