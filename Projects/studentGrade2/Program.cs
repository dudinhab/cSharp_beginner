string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeCourse1Name = 4;
int gradeCourse2Name = 3;
int gradeCourse3Name = 3;
int gradeCourse4Name = 3;
int gradeCourse5Name = 4;

decimal totalGrade = (course1Credit * gradeCourse1Name) + (course2Credit * gradeCourse2Name) + (course3Credit * gradeCourse3Name) + (course4Credit * gradeCourse4Name) + (course5Credit * gradeCourse5Name);
decimal totalCreditCourses = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal FinalGPA = totalGrade / totalCreditCourses;

int leadingDigit = (int)FinalGPA;
int firstDigit = (int)(FinalGPA * 10) % 10;
int secondDigit = (int)(FinalGPA * 100) % 10;

Console.Write(@$"Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         {gradeCourse1Name}       {course1Credit}
Algebra 101         {gradeCourse2Name}       {course2Credit}
Biology 101         {gradeCourse3Name}       {course3Credit}
Computer Science I  {gradeCourse4Name}       {course4Credit}
Psychology 101      {gradeCourse5Name}       {course5Credit}

Final GPA:          {leadingDigit}.{firstDigit}{secondDigit}");