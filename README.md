# The Scenario
- This is a pricing system for a pizza shop. They're expanding beyond simple Cheese and Pepperoni and decided on a little automation to generate the price and description. Not much, just making life a little easier. 
- This is just the price calculation for pizzas. We can imagine someone else will build the UI on top of your logic. Do whatever you want, they'll have your source code and can make it work.
- Implmentation Details
    - CSharp: There should be a Solution with a ClassLibrary project and Unit Test project
    - No UI and No Database
        - The focus on this training is Object Oriented. We'll get to UI and database in later lessons. They need their own focus.

# Setup
Fork this repo.

## Collaboration
I'll need access as a collaborator on your forked repo. See [here](https://help.github.com/en/github/setting-up-and-managing-your-github-user-account/inviting-collaborators-to-a-personal-repository) for a guide to that.

## Branching
* Create a 'dev' branch from 'main'
* Create a 'FeatureSet01' branch from 'dev'. This is where the work for the first set of features will be done.

# Phases
There are two phases to this training.
## Phase 1
Do your best SOLID and Object Oriented code.
This is an opportunity for you to apply the concepts in a greenfield codebase. There is no deadline. No rush to get it out. Take the time to do the implementation you want to.
You should think about and explore the ideas, concepts, and practices that are out there for good SOLID/OOP. The SOLID/OOP practices you use and apply in this phase will guide the next phase.
### Process
* Create a branch for the requirements to be implemented in. The first branch is FeatureSet01.
* I provide a set of requirements in this ReadMe.md in your FeatureSetXX branch.
* You implement those requirements in that branch. Focus on SOLID and OOP pracitces, principles, and patterns.
* When you are ready for the next set of requirements, create a Pull Request to the 'dev' branch
* I'll review/approve the Pull Request with any comments/guidance I want to provide.
* Once we're both satisfied with the state of the code; we start back at the top with the next set of requirements.

## Phase 2
Once you've completed the requirements with your best effort SOLID/OOP, we move to phase 2. How phase 1 goes will direct how phase 2 goes.

We might start back over with the end state of FeatureSet01 and refactor the code into better SOLID/OOP code. Then build ontop of that with better understanding of the ideas.

We might use the end state and refactor it into better SOLID/OOP code.

We might do something entirely different.

I don't know. This is where the training will become VERY personalized. Where you are and what I think will best help you learn the OOP patterns, principles, and practiecds is where we'll start.

As we go through phase 2 in whatever form, we'll have discussions about what I think should change and how and why. This isn't an exercise to get a right answer, but to increase your understanding of the principles, patterns, and practices that make good SOLID/OOP code.

## Alternaate Phase
It's basically Phase 1 and Phase 2 combind. You follow Phase 1, and I make more OO focused comments through out.
 
# Testing
As the scenario specifices, there's no need for a UI, but we need to be able to verify our code works. We will use a Unit Test framework for this; which is why the solution starts with a Test Project.
Unit Testing is a standard practice in the industry and it's good to do. While not the focus of this training, much like Git, it's a technique for quality code that we'll use during this training.

# ***Optional*** Practices and Tools
These practices are optional while you work through the requirements. They are things I've found very useful, but are not required as part of the training.

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
