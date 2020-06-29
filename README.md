# The Scenario
- This is a pricing system for a pizza shop. They're expanding beyond simple Cheese and Pepperoni and decided on a little automation to generate the price and description. Not much, just making life a little easier. 
- This is just the price calculation for pizzas. We can imagine someone else will build the UI on top of your logic. Do whatever you want, they'll have your source code and can make it work.
- Implmentation Details
    - CSharp: There should be a Solution with a ClassLibrary project and Unit Test project
    - No UI and No Database
        - The focus on this training is Object Oriented. We'll get to UI and database in latter lessons. They need their own focus.

# Details
## Branching
* Create a 'dev' branch from 'master'
* Create a 'Feature1' branch from 'dev'. This is where the work for the first set of features will be done.
 
## The process
* I provide a set of requirements
* You implement the requirements in a Git branch (Feature1, Feature2, ...)
* When the requirements are implemented, create a Pull Request to the 'dev' branch
* I review/approve the Pull Request and with appropriate comments
  * This is where phase 1 and phase 2 significantly differ
* Once we're both satisfied with the state of the code, we start back at the top of this list
 
## Testing
As the scenario specifices, there's no need for a UI, but we need to be able to verify our code works. We will use a Unit Test framework for this; which is why the solution starts with a Test Project.
Unit Testing is a standard practice in the industry and it's good to do. While not the focus of this training, much like Git, it's a technique for quality code that we'll use during this training.
 
# ***Optional*** Practices
These practices are optional while you work through the requirements. They are things I've found very useful, but are not required as part of the training.
 
### Resharper
Resharper is a Visual Studio Extension made by JetBrains (https://www.jetbrains.com/resharper/). I won't code C# without it. It is invaluable to me for all of the assistance and speed it provides me while I'm writing code.

### Fluent Assertions
Fluent Assertions (https://fluentassertions.com/) is a very extensive set of extension methods that allow you to more naturally specify the expected outcome of a TDD or BDD-style unit tests. 
This is already configured in the NuGet packages for the test project
 
### Commits
Good commit messages are important to a well understood code repository. I've found the following resources invaluable to improving the quality of my commit messages.
Interestingly, I've found a lot of the information and practices in 'Good Git Commit Messages' are almost not relevant when using 'Arlo's Git Notation'.
Neither of these need to be followed; I include them here because I find it helps me focus on small changes when I think about what the commit message will be.
 
#### Good Git Commit Messages
[https://chris.beams.io/posts/git-commit/](https://chris.beams.io/posts/git-commit/)
This will provide information about how to write good commit messages. A tool with good support for this is the [GitHub desktop client](https://desktop.github.com/).
Visual Studio and the command line do not support this style of git commits; you should.
The rules are summarized below, but the article is crucial to understanding how to create good commit messages.
 
> The seven rules of a great Git commit message.
> 
> * Separate subject from body with a blank line
> * Limit the subject line to 50 characters
> * Capitalize the subject line
> * Do not end the subject line with a period
> * Use the imperative mood in the subject line
> * Wrap the body at 72 characters
> * Use the body to explain what and why vs. how
 
#### Good Commit Sizes
Use [Arlo's Git Notation](https://github.com/RefactoringCombos/ArlosCommitNotation) to have very informative summary of the commit.
While the above is great for big changes, don't do big commits. Do many small commits. This will enable quick scanning of the commits to identify the types of changes.
This will be very useful during discussions of the code, including my ability to review how the code has changed over time.
It may not seem like a lot, but being able to watch the code evolve can give amazing insight into the reasons and decisions without us having to have discussions.