using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_HighSchool_App.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>().HasData(
                new student { studentID = 1, studentFirstName = "Anderss", studentLastName = "Gappi", userName = "AnderssG", password = "AndG1234", email = "Anderss@gmail.com", studentAge = 48, Gender = gender.male },
                new student { studentID = 2, studentFirstName = "Maria", studentLastName = "Erik", userName = "MariaK", password = "MarE1234", email = "maria@gmail.com", studentAge = 42, Gender = gender.female },
                new student { studentID = 3, studentFirstName = "Anna", studentLastName = "Lars", userName = "AnnaL", password = "AnaL1234", email = "Anna@gmail.com", studentAge = 38, Gender = gender.female },
                new student { studentID = 4, studentFirstName = "Christina", studentLastName = "Peter", userName = "ChristinaP", password = "ChrP1234", email = "Christina@gmail.com", studentAge = 29, Gender = gender.female },
                new student { studentID = 5, studentFirstName = "Johan", studentLastName = "Gunner", userName = "JuhanG", password = "JuhG1234", email = "Johan@gmail.com", studentAge = 52, Gender = gender.male },
                new student { studentID = 6, studentFirstName = "Oskar", studentLastName = "Michal", userName = "OskarM", password = "OskM1234", email = "Oskar@gmail.com", studentAge = 33, Gender = gender.male },
                new student { studentID = 7, studentFirstName = "Erik", studentLastName = "Bjork", userName = "ErikB", password = "EriB1234", email = "Erik@gmail.com", studentAge = 32, Gender = gender.male },
                new student { studentID = 8, studentFirstName = "Kamilla", studentLastName = "Nystrom", userName = "Camilla", password = "CamN234", email = "Camilla@gmail.com", studentAge = 26, Gender = gender.female },
                new student { studentID = 9, studentFirstName = "Eva", studentLastName = "Eriksson", userName = "EvaE", password = "EvaE1234", email = "Eva@gmail.com", studentAge = 24, Gender = gender.female },
                new student { studentID = 10, studentFirstName = "Carl", studentLastName = "Olsson", userName = "CarlO", password = "CarlO1234", email = "Carl@gmail.com", studentAge = 30, Gender = gender.male },
                new student { studentID = 11, studentFirstName = "Marcus", studentLastName = "Fredrik", userName = "Marcus", password = "MarF1234", email = "Marcus@gmail.com", studentAge = 41, Gender = gender.male },
                new student { studentID = 12, studentFirstName = "Lena", studentLastName = "Gunner", userName = "LenaG", password = "LenaG1234", email = "Lena@gmail.com", studentAge = 34, Gender = gender.female },
                new student { studentID = 13, studentFirstName = "Hanna", studentLastName = "Bjorn", userName = "HannaB", password = "HanB1234", email = "Hanna@gmail.com", studentAge = 38, Gender = gender.female },
                new student { studentID = 14, studentFirstName = "Robert", studentLastName = "Ali", userName = "RobertA", password = "RobA1234", email = "Robert@gmail.com", studentAge = 25, Gender = gender.male },
                new student { studentID = 15, studentFirstName = "Johan", studentLastName = "Gunner", userName = "JuhanG", password = "JuhG1234", email = "William@gmail.com", studentAge = 36, Gender = gender.male },
                new student { studentID = 16, studentFirstName = "William", studentLastName = "Hinrik", userName = "WilliamH", password = "WilH1234", email = "Anderss@gmail.com", studentAge = 48, Gender = gender.male },
                new student { studentID = 17, studentFirstName = "Elsa", studentLastName = "Forsberg", userName = "ElsaF", password = "ElsF1234", email = "Elsa@gmail.com", studentAge = 23, Gender = gender.female },
                new student { studentID = 18, studentFirstName = "Dan", studentLastName = "Eklund", userName = "DanE", password = "DanE1234", email = "Dan@gmail.com", studentAge = 29, Gender = gender.male },
                new student { studentID = 19, studentFirstName = "David", studentLastName = "Gunnel", userName = "DavidG", password = "DavG1234", email = "David@gmail.com", studentAge = 35, Gender = gender.male },
                new student { studentID = 20, studentFirstName = "Karolin", studentLastName = "Holm", userName = "KarolinH", password = "JuhG1234", email = "Johan@gmail.com", studentAge = 52, Gender = gender.male },
                new student { studentID = 21, studentFirstName = "Emma", studentLastName = "Johansson", userName = "EmmaJ", password = "EmmJ1234", email = "Emma@gmail.com", studentAge = 41, Gender = gender.female },
                new student { studentID = 22, studentFirstName = "Astrid", studentLastName = "Lars", userName = "AstridL", password = "AstL1234", email = "Astrid@gmail.com", studentAge = 30, Gender = gender.female },
                new student { studentID = 23, studentFirstName = "Karl", studentLastName = "Nils", userName = "KarlN", password = "KarN1234", email = "Karl@gmail.com", studentAge = 37, Gender = gender.male },
                new student { studentID = 24, studentFirstName = "Hans", studentLastName = "Roberto", userName = "HansR", password = "HanR1234", email = "Hans@gmail.com", studentAge = 36, Gender = gender.male },
                new student { studentID = 25, studentFirstName = "Asa", studentLastName = "Sven", userName = "AsaS", password = "AsaS1234", email = "Asa@gmail.com", studentAge = 35, Gender = gender.female },
                new student { studentID = 26, studentFirstName = "Per", studentLastName = "Tomas", userName = "PerT", password = "PerT1234", email = "Per@gmail.com", studentAge = 43, Gender = gender.male },
                new student { studentID = 27, studentFirstName = "Kristin", studentLastName = "Magnus", userName = "KristinM", password = "KrsT1234", email = "Kristin@gmail.com", studentAge = 31, Gender = gender.female },
                new student { studentID = 28, studentFirstName = "Fredrik", studentLastName = "Simon", userName = "FredrikS", password = "FreS1234", email = "Fredrik@gmail.com", studentAge = 29, Gender = gender.male },
                new student { studentID = 29, studentFirstName = "Brigitta", studentLastName = "Larsson", userName = "BrigittaL", password = "BigL1234", email = "Brigitta@gmail.com", studentAge = 51, Gender = gender.female },
                new student { studentID = 30, studentFirstName = "Filip", studentLastName = "Anton", userName = "FilipA", password = "FilA1234", email = "Filip@gmail.com", studentAge = 44, Gender = gender.male }


                );

            modelBuilder.Entity<teacher>().HasData(
               new teacher { teacherID = 1, teacherFirstName = "Helen", teacherLastName = "Fredrik", teacherAge = 44, Gender = gender.female },
               new teacher { teacherID = 2, teacherFirstName = "Peter", teacherLastName = "Rolf", teacherAge = 38, Gender = gender.male },
               new teacher { teacherID = 3, teacherFirstName = "Lars", teacherLastName = "Johnsson", teacherAge = 42, Gender = gender.male },
               new teacher { teacherID = 4, teacherFirstName = "Filip", teacherLastName = "Niklas", teacherAge = 56, Gender = gender.male },
               new teacher { teacherID = 5, teacherFirstName = "Emilla", teacherLastName = "Gunner", teacherAge = 36, Gender = gender.female }

               );

            modelBuilder.Entity<subject>().HasData(
               new subject { subjectID = 1, Category = category.graphicDesign, GraphicDesign = graphicD.adobeIllustrator },
               new subject { subjectID = 2, Category = category.graphicDesign, GraphicDesign = graphicD.adobePhotoshp },
               new subject { subjectID = 3, Category = category.graphicDesign, GraphicDesign = graphicD.corelDrow },
               new subject { subjectID = 4, Category = category.webDevelopment, WebbDevelopment = webD.Html },
               new subject { subjectID = 5, Category = category.webDevelopment, WebbDevelopment = webD.Css },
               new subject { subjectID = 6, Category = category.webDevelopment, WebbDevelopment = webD.javaScript },
               new subject { subjectID = 7, Category = category.programming, Programming = programming.Csharp },
               new subject { subjectID = 8, Category = category.programming, Programming = programming.Java },
               new subject { subjectID = 9, Category = category.programming, Programming = programming.python },
               new subject { subjectID = 10, Category = category.dataBase, DataBase = dataB.sqlServer },
               new subject { subjectID = 11, Category = category.dataBase, DataBase = dataB.oracle },
               new subject { subjectID = 12, Category = category.dataBase, DataBase = dataB.mySql }

               );


            modelBuilder.Entity<Relation>().HasData(
              new Relation { ID = 1, GPA = gpa.B, StudyType = studyType.distance, Level = level.high, studentIDFK = 1, teacherIDFK = 3, subjectIDFK = 7 },
              new Relation { ID = 2, GPA = gpa.C, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 1, teacherIDFK = 3, subjectIDFK = 10 },
              new Relation { ID = 3, GPA = gpa.E, StudyType = studyType.onSite, Level = level.primary, studentIDFK = 2, teacherIDFK = 1, subjectIDFK = 1 },
              new Relation { ID = 4, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 2, teacherIDFK = 1, subjectIDFK = 3 },
              new Relation { ID = 5, GPA = gpa.A, StudyType = studyType.distance, Level = level.high, studentIDFK = 3, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 6, GPA = gpa.A, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 3, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 7, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 3, teacherIDFK = 2, subjectIDFK = 6 },
              new Relation { ID = 8, GPA = gpa.D, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 4, teacherIDFK = 1, subjectIDFK = 3 },
              new Relation { ID = 9, GPA = gpa.B, StudyType = studyType.onSite, Level = level.high, studentIDFK = 5, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 10, GPA = gpa.C, StudyType = studyType.both, Level = level.secondary, studentIDFK = 6, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 11, GPA = gpa.E, StudyType = studyType.distance, Level = level.primary, studentIDFK = 7, teacherIDFK = 1, subjectIDFK = 1 },
              new Relation { ID = 12, GPA = gpa.D, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 8, teacherIDFK = 2, subjectIDFK = 6 },
              new Relation { ID = 13, GPA = gpa.A, StudyType = studyType.onSite, Level = level.high, studentIDFK = 10, teacherIDFK = 4, subjectIDFK = 8 },
              new Relation { ID = 14, GPA = gpa.E, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 10, teacherIDFK = 4, subjectIDFK = 11 },
              new Relation { ID = 15, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 11, teacherIDFK = 5, subjectIDFK = 9 },
              new Relation { ID = 16, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 11, teacherIDFK = 5, subjectIDFK = 12 },
              new Relation { ID = 17, GPA = gpa.B, StudyType = studyType.both, Level = level.high, studentIDFK = 12, teacherIDFK = 3, subjectIDFK = 6 },
              new Relation { ID = 18, GPA = gpa.C, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 12, teacherIDFK = 3, subjectIDFK = 7 },
              new Relation { ID = 19, GPA = gpa.A, StudyType = studyType.distance, Level = level.primary, studentIDFK = 12, teacherIDFK = 3, subjectIDFK = 10 },
              new Relation { ID = 20, GPA = gpa.F, StudyType = studyType.both, Level = level.secondary, studentIDFK = 13, teacherIDFK = 5, subjectIDFK = 8 },
              new Relation { ID = 21, GPA = gpa.A, StudyType = studyType.both, Level = level.high, studentIDFK = 13, teacherIDFK = 5, subjectIDFK = 11 },
              new Relation { ID = 22, GPA = gpa.E, StudyType = studyType.both, Level = level.secondary, studentIDFK = 14, teacherIDFK = 5, subjectIDFK = 9 },
              new Relation { ID = 23, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 14, teacherIDFK = 5, subjectIDFK = 12 },
              new Relation { ID = 24, GPA = gpa.A, StudyType = studyType.onSite, Level = level.primary, studentIDFK = 15, teacherIDFK = 1, subjectIDFK = 1 },
              new Relation { ID = 25, GPA = gpa.B, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 15, teacherIDFK = 1, subjectIDFK = 2 },
              new Relation { ID = 26, GPA = gpa.A, StudyType = studyType.distance, Level = level.primary, studentIDFK = 15, teacherIDFK = 1, subjectIDFK = 3 },
              new Relation { ID = 27, GPA = gpa.D, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 16, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 28, GPA = gpa.A, StudyType = studyType.both, Level = level.high, studentIDFK = 16, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 29, GPA = gpa.E, StudyType = studyType.both, Level = level.secondary, studentIDFK = 16, teacherIDFK = 2, subjectIDFK = 6 },
              new Relation { ID = 30, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 17, teacherIDFK = 3, subjectIDFK = 7 },
              new Relation { ID = 31, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 18, teacherIDFK = 4, subjectIDFK = 8 },
              new Relation { ID = 32, GPA = gpa.B, StudyType = studyType.both, Level = level.secondary, studentIDFK = 19, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 33, GPA = gpa.C, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 19, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 34, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 20, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 35, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 20, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 36, GPA = gpa.A, StudyType = studyType.distance, Level = level.high, studentIDFK = 20, teacherIDFK = 2, subjectIDFK = 6 },
              new Relation { ID = 37, GPA = gpa.B, StudyType = studyType.both, Level = level.secondary, studentIDFK = 20, teacherIDFK = 3, subjectIDFK = 7 },
              new Relation { ID = 38, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 20, teacherIDFK = 3, subjectIDFK = 10 },
              new Relation { ID = 39, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 21, teacherIDFK = 3, subjectIDFK = 10 },
              new Relation { ID = 40, GPA = gpa.F, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 21, teacherIDFK = 4, subjectIDFK = 11 },
              new Relation { ID = 41, GPA = gpa.A, StudyType = studyType.both, Level = level.primary, studentIDFK = 21, teacherIDFK = 5, subjectIDFK = 12 },
              new Relation { ID = 42, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 22, teacherIDFK = 5, subjectIDFK = 9 },
              new Relation { ID = 43, GPA = gpa.A, StudyType = studyType.both, Level = level.high, studentIDFK = 22, teacherIDFK = 5, subjectIDFK = 12 },
              new Relation { ID = 44, GPA = gpa.E, StudyType = studyType.both, Level = level.secondary, studentIDFK = 23, teacherIDFK = 1, subjectIDFK = 1 },
              new Relation { ID = 45, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 23, teacherIDFK = 1, subjectIDFK = 2 },
              new Relation { ID = 46, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 23, teacherIDFK = 1, subjectIDFK = 3 },
              new Relation { ID = 47, GPA = gpa.B, StudyType = studyType.both, Level = level.secondary, studentIDFK = 24, teacherIDFK = 1, subjectIDFK = 4 },
              new Relation { ID = 48, GPA = gpa.C, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 24, teacherIDFK = 1, subjectIDFK = 5 },
              new Relation { ID = 49, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 24, teacherIDFK = 1, subjectIDFK = 6 },
              new Relation { ID = 50, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 25, teacherIDFK = 2, subjectIDFK = 8 },
              new Relation { ID = 51, GPA = gpa.B, StudyType = studyType.both, Level = level.high, studentIDFK = 25, teacherIDFK = 2, subjectIDFK = 11 },
              new Relation { ID = 52, GPA = gpa.A, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 26, teacherIDFK = 4, subjectIDFK = 7 },
              new Relation { ID = 53, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 26, teacherIDFK = 4, subjectIDFK = 9 },
              new Relation { ID = 54, GPA = gpa.E, StudyType = studyType.both, Level = level.secondary, studentIDFK = 27, teacherIDFK = 3, subjectIDFK = 7 },
              new Relation { ID = 55, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 27, teacherIDFK = 3, subjectIDFK = 8 },
              new Relation { ID = 56, GPA = gpa.D, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 27, teacherIDFK = 4, subjectIDFK = 10 },
              new Relation { ID = 57, GPA = gpa.B, StudyType = studyType.both, Level = level.secondary, studentIDFK = 27, teacherIDFK = 4, subjectIDFK = 11 },
              new Relation { ID = 58, GPA = gpa.F, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 27, teacherIDFK = 1, subjectIDFK = 5 },
              new Relation { ID = 59, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 28, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 60, GPA = gpa.D, StudyType = studyType.both, Level = level.secondary, studentIDFK = 28, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 61, GPA = gpa.B, StudyType = studyType.onSite, Level = level.high, studentIDFK = 28, teacherIDFK = 2, subjectIDFK = 6 },
              new Relation { ID = 62, GPA = gpa.A, StudyType = studyType.both, Level = level.secondary, studentIDFK = 28, teacherIDFK = 5, subjectIDFK = 9 },
              new Relation { ID = 63, GPA = gpa.E, StudyType = studyType.both, Level = level.primary, studentIDFK = 28, teacherIDFK = 5, subjectIDFK = 12 },
              new Relation { ID = 64, GPA = gpa.E, StudyType = studyType.both, Level = level.secondary, studentIDFK = 29, teacherIDFK = 3, subjectIDFK = 7 },
              new Relation { ID = 65, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 29, teacherIDFK = 3, subjectIDFK = 8 },
              new Relation { ID = 66, GPA = gpa.D, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 30, teacherIDFK = 1, subjectIDFK = 1 },
              new Relation { ID = 67, GPA = gpa.B, StudyType = studyType.both, Level = level.secondary, studentIDFK = 30, teacherIDFK = 1, subjectIDFK = 2 },
              new Relation { ID = 68, GPA = gpa.F, StudyType = studyType.distance, Level = level.secondary, studentIDFK = 30, teacherIDFK = 1, subjectIDFK = 3 },
              new Relation { ID = 69, GPA = gpa.C, StudyType = studyType.both, Level = level.primary, studentIDFK = 30, teacherIDFK = 2, subjectIDFK = 4 },
              new Relation { ID = 70, GPA = gpa.D, StudyType = studyType.onSite, Level = level.secondary, studentIDFK = 30, teacherIDFK = 2, subjectIDFK = 5 },
              new Relation { ID = 71, GPA = gpa.B, StudyType = studyType.both, Level = level.high, studentIDFK = 30, teacherIDFK = 2, subjectIDFK = 6 }

              );

        }

    }
}
