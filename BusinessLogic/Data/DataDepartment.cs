using System;
using System.Collections.Generic;
using BusinessLogic.Entities.Company;

namespace BusinessLogic.Data
{
    public class DataDepartment
    {
        public static List<Department> GetDepartments()
        {
            var departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    DeptName = "Information Technology",
                    Description = "Manages all IT infrastructure, software development, and technical support services",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "System Admin",
                    LastModifiedOn = new DateTime(2024, 1, 10),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 2,
                    DeptName = "Human Resources",
                    Description = "Handles recruitment, employee relations, benefits, and organizational development",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "HR Manager",
                    LastModifiedOn = new DateTime(2024, 1, 15),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 3,
                    DeptName = "Finance & Accounting",
                    Description = "Manages financial planning, budgeting, accounting, and financial reporting",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Finance Director",
                    LastModifiedOn = new DateTime(2024, 1, 20),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 4,
                    DeptName = "Marketing",
                    Description = "Develops marketing strategies, brand management, and promotional campaigns",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Marketing Manager",
                    LastModifiedOn = new DateTime(2024, 1, 12),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 5,
                    DeptName = "Sales",
                    Description = "Manages customer relationships, sales operations, and revenue generation",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Sales Director",
                    LastModifiedOn = new DateTime(2024, 1, 18),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 6,
                    DeptName = "Operations",
                    Description = "Oversees day-to-day business operations and process optimization",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Operations Manager",
                    LastModifiedOn = new DateTime(2024, 1, 14),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 7,
                    DeptName = "Research & Development",
                    Description = "Focuses on innovation, product development, and technological advancement",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "R&D Director",
                    LastModifiedOn = new DateTime(2024, 1, 16),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 8,
                    DeptName = "Customer Service",
                    Description = "Provides customer support, handles inquiries, and maintains customer satisfaction",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Customer Service Manager",
                    LastModifiedOn = new DateTime(2024, 1, 13),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 9,
                    DeptName = "Legal",
                    Description = "Handles legal matters, compliance, contracts, and regulatory affairs",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Legal Counsel",
                    LastModifiedOn = new DateTime(2024, 1, 17),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 10,
                    DeptName = "Facilities Management",
                    Description = "Manages building maintenance, security, and workplace environment",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 1, 15),
                    LastModifiedBy = "Facilities Manager",
                    LastModifiedOn = new DateTime(2024, 1, 19),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 11,
                    DeptName = "Quality Assurance",
                    Description = "Ensures product quality, compliance with standards, and continuous improvement",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 1),
                    LastModifiedBy = "QA Manager",
                    LastModifiedOn = new DateTime(2024, 1, 21),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 12,
                    DeptName = "Supply Chain",
                    Description = "Manages procurement, logistics, inventory, and supplier relationships",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 1),
                    LastModifiedBy = "Supply Chain Manager",
                    LastModifiedOn = new DateTime(2024, 1, 22),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 13,
                    DeptName = "Business Development",
                    Description = "Identifies growth opportunities, partnerships, and market expansion strategies",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 1),
                    LastModifiedBy = "Business Development Manager",
                    LastModifiedOn = new DateTime(2024, 1, 23),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 14,
                    DeptName = "Product Management",
                    Description = "Defines product strategy, roadmap, and feature prioritization",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 1),
                    LastModifiedBy = "Product Manager",
                    LastModifiedOn = new DateTime(2024, 1, 24),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 15,
                    DeptName = "Data Analytics",
                    Description = "Provides business intelligence, data insights, and analytical support",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 1),
                    LastModifiedBy = "Data Analytics Manager",
                    LastModifiedOn = new DateTime(2024, 1, 25),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 16,
                    DeptName = "Training & Development",
                    Description = "Designs and delivers employee training programs and skill development",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 15),
                    LastModifiedBy = "Training Manager",
                    LastModifiedOn = new DateTime(2024, 1, 26),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 17,
                    DeptName = "Communications",
                    Description = "Manages internal and external communications, public relations, and media",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 15),
                    LastModifiedBy = "Communications Manager",
                    LastModifiedOn = new DateTime(2024, 1, 27),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 18,
                    DeptName = "Risk Management",
                    Description = "Identifies, assesses, and mitigates business risks and compliance issues",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 15),
                    LastModifiedBy = "Risk Manager",
                    LastModifiedOn = new DateTime(2024, 1, 28),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 19,
                    DeptName = "Innovation Lab",
                    Description = "Explores emerging technologies and disruptive business models",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 15),
                    LastModifiedBy = "Innovation Director",
                    LastModifiedOn = new DateTime(2024, 1, 29),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 20,
                    DeptName = "Sustainability",
                    Description = "Develops and implements environmental and social responsibility initiatives",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 2, 15),
                    LastModifiedBy = "Sustainability Manager",
                    LastModifiedOn = new DateTime(2024, 1, 30),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 21,
                    DeptName = "Digital Transformation",
                    Description = "Leads organizational change and technology adoption initiatives",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 1),
                    LastModifiedBy = "Digital Transformation Manager",
                    LastModifiedOn = new DateTime(2024, 2, 1),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 22,
                    DeptName = "Cybersecurity",
                    Description = "Protects information systems and data from security threats",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 1),
                    LastModifiedBy = "Cybersecurity Manager",
                    LastModifiedOn = new DateTime(2024, 2, 2),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 23,
                    DeptName = "Cloud Infrastructure",
                    Description = "Manages cloud-based systems, platforms, and services",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 1),
                    LastModifiedBy = "Cloud Infrastructure Manager",
                    LastModifiedOn = new DateTime(2024, 2, 3),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 24,
                    DeptName = "Mobile Development",
                    Description = "Develops mobile applications and mobile-first solutions",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 1),
                    LastModifiedBy = "Mobile Development Manager",
                    LastModifiedOn = new DateTime(2024, 2, 4),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 25,
                    DeptName = "UI/UX Design",
                    Description = "Creates user interface designs and user experience strategies",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 1),
                    LastModifiedBy = "UI/UX Design Manager",
                    LastModifiedOn = new DateTime(2024, 2, 5),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 26,
                    DeptName = "DevOps",
                    Description = "Manages development operations, CI/CD pipelines, and deployment processes",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 15),
                    LastModifiedBy = "DevOps Manager",
                    LastModifiedOn = new DateTime(2024, 2, 6),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 27,
                    DeptName = "Database Administration",
                    Description = "Manages database systems, performance, and data integrity",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 15),
                    LastModifiedBy = "Database Administrator",
                    LastModifiedOn = new DateTime(2024, 2, 7),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 28,
                    DeptName = "Network Engineering",
                    Description = "Designs and maintains network infrastructure and connectivity",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 15),
                    LastModifiedBy = "Network Engineer",
                    LastModifiedOn = new DateTime(2024, 2, 8),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 29,
                    DeptName = "System Administration",
                    Description = "Manages server systems, operating systems, and infrastructure",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 15),
                    LastModifiedBy = "System Administrator",
                    LastModifiedOn = new DateTime(2024, 2, 9),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 30,
                    DeptName = "Technical Support",
                    Description = "Provides technical assistance and troubleshooting for end users",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 3, 15),
                    LastModifiedBy = "Technical Support Manager",
                    LastModifiedOn = new DateTime(2024, 2, 10),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 31,
                    DeptName = "Project Management",
                    Description = "Oversees project planning, execution, and delivery across the organization",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 1),
                    LastModifiedBy = "Project Management Office",
                    LastModifiedOn = new DateTime(2024, 2, 11),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 32,
                    DeptName = "Change Management",
                    Description = "Facilitates organizational change and transition processes",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 1),
                    LastModifiedBy = "Change Management Specialist",
                    LastModifiedOn = new DateTime(2024, 2, 12),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 33,
                    DeptName = "Process Improvement",
                    Description = "Identifies and implements process optimization and efficiency improvements",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 1),
                    LastModifiedBy = "Process Improvement Manager",
                    LastModifiedOn = new DateTime(2024, 2, 13),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 34,
                    DeptName = "Strategic Planning",
                    Description = "Develops long-term business strategy and strategic initiatives",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 1),
                    LastModifiedBy = "Strategic Planning Director",
                    LastModifiedOn = new DateTime(2024, 2, 14),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 35,
                    DeptName = "Performance Management",
                    Description = "Manages employee performance evaluation and development planning",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 1),
                    LastModifiedBy = "Performance Management Specialist",
                    LastModifiedOn = new DateTime(2024, 2, 15),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 36,
                    DeptName = "Talent Acquisition",
                    Description = "Focuses on recruitment, sourcing, and hiring strategies",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 15),
                    LastModifiedBy = "Talent Acquisition Manager",
                    LastModifiedOn = new DateTime(2024, 2, 16),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 37,
                    DeptName = "Employee Relations",
                    Description = "Handles workplace conflicts, policies, and employee satisfaction",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 15),
                    LastModifiedBy = "Employee Relations Specialist",
                    LastModifiedOn = new DateTime(2024, 2, 17),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 38,
                    DeptName = "Compensation & Benefits",
                    Description = "Manages salary structures, benefits programs, and total rewards",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 15),
                    LastModifiedBy = "Compensation Manager",
                    LastModifiedOn = new DateTime(2024, 2, 18),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 39,
                    DeptName = "Learning & Development",
                    Description = "Creates and delivers training programs and professional development",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 15),
                    LastModifiedBy = "Learning & Development Manager",
                    LastModifiedOn = new DateTime(2024, 2, 19),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 40,
                    DeptName = "Organizational Development",
                    Description = "Focuses on culture, structure, and organizational effectiveness",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 4, 15),
                    LastModifiedBy = "Organizational Development Manager",
                    LastModifiedOn = new DateTime(2024, 2, 20),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 41,
                    DeptName = "Financial Planning",
                    Description = "Develops financial forecasts, budgets, and investment strategies",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 1),
                    LastModifiedBy = "Financial Planning Manager",
                    LastModifiedOn = new DateTime(2024, 2, 21),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 42,
                    DeptName = "Tax & Compliance",
                    Description = "Manages tax planning, compliance, and regulatory reporting",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 1),
                    LastModifiedBy = "Tax Manager",
                    LastModifiedOn = new DateTime(2024, 2, 22),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 43,
                    DeptName = "Internal Audit",
                    Description = "Conducts internal audits and risk assessments",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 1),
                    LastModifiedBy = "Internal Audit Manager",
                    LastModifiedOn = new DateTime(2024, 2, 23),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 44,
                    DeptName = "Treasury",
                    Description = "Manages cash flow, investments, and financial risk",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 1),
                    LastModifiedBy = "Treasury Manager",
                    LastModifiedOn = new DateTime(2024, 2, 24),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 45,
                    DeptName = "Cost Accounting",
                    Description = "Analyzes costs and provides cost management insights",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 1),
                    LastModifiedBy = "Cost Accounting Manager",
                    LastModifiedOn = new DateTime(2024, 2, 25),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 46,
                    DeptName = "Digital Marketing",
                    Description = "Manages online marketing channels and digital campaigns",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 15),
                    LastModifiedBy = "Digital Marketing Manager",
                    LastModifiedOn = new DateTime(2024, 2, 26),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 47,
                    DeptName = "Content Marketing",
                    Description = "Creates and distributes valuable content to attract and engage audiences",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 15),
                    LastModifiedBy = "Content Marketing Manager",
                    LastModifiedOn = new DateTime(2024, 2, 27),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 48,
                    DeptName = "Social Media",
                    Description = "Manages social media presence and community engagement",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 15),
                    LastModifiedBy = "Social Media Manager",
                    LastModifiedOn = new DateTime(2024, 2, 28),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 49,
                    DeptName = "Brand Management",
                    Description = "Develops and maintains brand identity and positioning",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 15),
                    LastModifiedBy = "Brand Manager",
                    LastModifiedOn = new DateTime(2024, 2, 29),
                    IsDeleted = false
                },
                new Department
                {
                    Id = 50,
                    DeptName = "Market Research",
                    Description = "Conducts market analysis and consumer behavior research",
                    CreatedBy = "System Admin",
                    CreatedOn = new DateTime(2023, 5, 15),
                    LastModifiedBy = "Market Research Manager",
                    LastModifiedOn = new DateTime(2024, 3, 1),
                    IsDeleted = false
                }
            };

            return departments;
        }
    }
}
