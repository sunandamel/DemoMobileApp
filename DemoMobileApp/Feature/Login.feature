Feature: Login

  Scenario Outline: login to mobile App with "<username>"
    Given the app is launched
    When I tap on the "<username>"
    And I tap on the "<loginButton>" button
    Then I should see the "<expectedScreenOrError>" screen

    Examples:
    | username        | loginButton | expectedScreenOrError                   |
    | standard_user   | LOGIN       | PRODUCTS                                |
    | locked_out_user | LOGIN       | Sorry, this user has been locked out.   |
