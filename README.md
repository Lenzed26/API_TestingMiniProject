# API_TestingMiniProject

## Project Description

We will be using the Rick and Morty API using  a scrum framework, which covers unit tests to test the API responses and request using rest sharp. As a team, we used GitHub as our Control Version System.

## Project Goals

- The project has to be a 3 Tier Application
  - It should include a Model, Business and GUI Layer
- The project should also include Tests where there are multiple test cases to ensure the application works as intended
- The project should include an SQL database with at least two linked tables. These tables will be:
  - The "User" Table to keep track of Username and Password as well as any other data that is related to the user. This table will have a 1 to 1 relationship with with roles which stored whether the user is an admin or a normal user.
  - The "Role" Table to link the Users to their access and permissions type.
- The project should use Entity Framework to manage the relationship between the backend object model and the database
- The project should be easily tracked through git commits and have a thorough ReadMe File.
- The project should also fit the project Description

## Class Diagrams

##### Model

![Model_Class_Diagram](/Images/Model_Class_Diagram.JPG)

## Sprints

### Sprint 1

#### Kanban Board at the start

![Sprint_One_Before](/Images/Sprint_One_Before.JPG)

#### Sprint Goals

- Complete User Story 1.1
- Complete User Story 2.1
- Complete User Story 3.2
- Complete User Story 4.1
- Complete User Story 5.1
- Update README.md
- Commit changes to GitHub
- Add Sprint Review and Retrospective

#### Kanban Board at the end

![Sprint_One_Before](/Images/Sprint_One_Before.JPG)

#### Sprint Review

In sprint 1, We were able to get test the Rick and Morty API which consisted of three categories "**Characters**", "**Locations**" and "**Episodes**". As a team we were able to create tests for both sad and happy paths for single and bulk results. We had a blocker dealing with generic classes with the type being an error and after debugging we were to resolve it in good time.

#### Sprint Retrospective

As a team, we are communication with the team on the user cases to allocate testing to individual. We were able to use Git pull requests and learn more about how the process worked as a team. 

### Sprint 2

#### Kanban Board at the start

![Sprint_Two_Before](/Images/Sprint_Two_Before.JPG)

#### Sprint Goals

- Complete User Story 5.2
- Complete User Story 3.1
- Complete User Story 2.2
- Update README.md
- Commit changes to GitHub
- Add Sprint Review and Retrospective

### Kanban Board at the end

![Sprint_Two_After](/Images/Sprint_Two_After.JPG)

#### Sprint Review

For sprint 2, In this sprint we checked if the names it pulls give a list of id's and we are trying to pull a list of ids, we also focused to add some more tests to cover sad paths. We also worked on the README.md to organise all our sprint goals and instructions to download any NuGet packages if the project has to be downloaded from GitHub.

#### Sprint Retrospective

[Add it at the end of sprint 2]

## Setup Instructions

If you would like to download the published version of the application please go to here:

Otherwise please follow these setup instructions to be able to edit and work on this project yourself. If you haven't already please start by installing Visual Studio and downloading the Project from GitHub.

#### Step 1:

Once you have opened the Project in Visual Studio if the packages haven't been automatically installed you must first do this:

1. Open the APIClient and right click on Dependencies and click on manage Nuget packages.
2. From here click on browse and search for "Newtonsoft.Json", "NUnit", "NUnit3TestAdapter", "RestSharp", "System.Configuration.ConfigurationManager", "System.Security.AccessControl", "System.Security.Permissions" and "System.Security.Principal.Windows" install both of these packages.

![NuGet Packages](/Images/NuGet Packages.JPG)

Once you have completed all these steps you will have setup the complete solution for the APIClient. You can now test, add functionality and play around with the application.
