/*Se nos proporciona el nombre y la información de la clase del alumno.
Cada clase tiene un nombre, la calificación del alumno y el número de horas en créditos de esa clase.
La aplicación debe realizar operaciones matemáticas básicas para calcular la nota media global del alumno determinado.
La aplicación debe generar o mostrar el nombre del alumno, la información de la clase y la nota media global.
Para calcular la nota media global:

Multiplique la nota de un curso por el número de horas en créditos de ese curso.
Hágalo para cada curso y reúna los resultados.
Divida la suma resultante por el número total de horas en créditos.*/

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

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Grade * course1Credit;
totalGradePoints += course2Grade * course2Credit;
totalGradePoints += course3Grade * course3Credit;
totalGradePoints += course4Grade * course4Credit;
totalGradePoints += course5Grade * course5Credit;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;


Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");

