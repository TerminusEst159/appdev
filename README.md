# Student Attendance Checker

A Windows desktop app for taking class attendance. Teachers log in, pick a
class and date, mark each student as Present, Absent or Late, and save the
records to a cloud database.

## Features
- Email and password login (Supabase Auth)
- Role check: teachers see the attendance screen
- Load the students enrolled in a class
- Mark and save attendance per class per day
- Re-saving the same day updates the existing records

## Built with
- C# and Windows Forms (.NET 8)
- Supabase (Postgres database and authentication)
- Supabase C# client library (NuGet package `Supabase`)

## How to run
1. Create a free project at supabase.com.
2. In the SQL Editor, create the tables `profiles`, `classes`,
   `enrollments` and `attendance`, and turn on Row Level Security.
3. In Authentication, add a teacher user and a few student users, then add
   matching rows in `profiles` (role is `teacher` or `student`).
4. Add a class and enroll the students.
5. Open `SupabaseService.cs` and set `Url` and `AnonKey` to your project URL
   and publishable key.
6. Open the solution in Visual Studio and press F5.

## Database tables
- `profiles` (id, full_name, role)
- `classes` (id, name, teacher_id)
- `enrollments` (class_id, student_id)
- `attendance` (id, class_id, student_id, date, status)

## Author
Agolito Jean Prince, BSIT AND BT3102
