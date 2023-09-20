using System.Collections.ObjectModel;

namespace CollectionViewIssue
{
    public static class AssessmentsMockup
    {
        private static readonly Random random = new();

        private static readonly string[] AssessmentTitles =
        [
            "Web Development Fundamentals",
            "Introduction to Programming",
            "Advanced Algorithms",
            "Data Structures and Analysis",
            "Database Management Systems",
            "Network Security Basics",
            "Mobile App Development",
            "Artificial Intelligence Concepts",
            "Software Engineering Principles",
            "Human-Computer Interaction",
            "Operating Systems Fundamentals",
            "Graphics and Visualization",
            "Cloud Computing Essentials",
            "IoT Frameworks and Applications",
            "Cybersecurity Practices"
        ];

        private static readonly string[] Programs =
        [
            "International Computer Science",
            "Software Engineering",
            "Networks and Systems",
            "Data Science and Analytics",
            "Artificial Intelligence"
        ];

        private static readonly string[] Courses =
        [
            "English Literature",
            "Arabic Culture",
            "Database II",
            "Programming Concepts",
            "Advanced Networking",
            "Calculus II",
            "Physics Principles",
            "Computer Graphics",
            "Humanities",
            "Business Management"
        ];

        public static ObservableCollection<Assessment> GetAssessments()
        {
            ObservableCollection<Assessment> assessments = [];
            for (int i = 0; i < 15; i++)
            {
                assessments.Add(new Assessment
                {
                    Title = AssessmentTitles[random.Next(AssessmentTitles.Length)],
                    Program = Programs[random.Next(Programs.Length)],
                    Course = Courses[random.Next(Courses.Length)],
                    EndDate = DateTime.Now.AddDays(random.Next(1, 60)).ToString(),
                    CurrentProgress = random.Next(1, 100),
                    TotalProgress = 12,
                    Status = (AssessmentStatus)random.Next(0, 3)
                });
            }
            return assessments;
        }
    }
}