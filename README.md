## MSSA_Exercise_6B
> Find the value of Pi using the MonteCarlo method

Take a unit circle with a radius of 1. Using the top right quadrant and *randomly* generated point pairs (x & y), find the ratio of points that fall within the circle to those that are outside the circle.  Multiply those results by 4 to get the estimated value of Pi.  Display the estimated value, as well as the absolute difference to actual Pi.

**Questions**
1. Why do we multiply the value from (your overlapping points ratio) by 4?
    - **We are estimating only one quadrant of the circle**
2. What do you observe in the output when running your program with parameters of increasing size?
    - **We get more acurate results with more iterations**
3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
    - **No, the results are slightly different each time because the `Random` class uses the current timestamp as a seed**
4. Find a parameter that requires multiple seconds of run time. What is that parameter? How accurate is the estimated value of Pi?
    - **10,000,000 iterations took more than a second and gave a result that was an absolute differenece of 0.00047 off of actual `Math.Pi`**
5. Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
    - **Calculating the odds of getting blackjack (Ace and a 10 point card) on an opening hand with a single deck of cards**