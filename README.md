# Auden Automation Test Framework Example

## Tools Used

- Selenium
- Specflow

## Framework Pattern Used
- Screenplay Pattern

The screenplay pattern was used simply to show the use of a different design pattern to the well known page object pattern. Screenplay pattern is a multi-layered framework compared to the 1 level layer POM framework, which enables better code reuse and cleaner tests. It allows you to express your tests in the domain language of your business and closely follows SOLID design principles. A screenplay pattern framework takes longer to initially set up, but in the long run becomes more efficient to use than a framework based on POM. Some elements of the screenplay pattern missing from the current implementation include screens classes, Actions classes (this is where explicit waits and retry mechanisms would be implemented).