# The Effects of Visual Priming on Perceived Vehicle Performance in Video Games

# Introduction

As an aspiring researcher, I wanted to create a project that would allow me to apply the knowledge I acquired during my first year of study and this led to the development of a small-scale research experiment designed to explore the psychological phenomenon of priming within the context of video games.

To do so, I created a racing game (more accurately, a traffic simulator) in which players were given the illusion of choosing between three distinct vehicles. However, all three cars were identical in performance, allowing me to test whether visual and contextual priming alone could influence players’ perceptions of speed.

# Background

Priming refers to a cognitive phenomenon where exposure to one stimulus influences how a person responds to a later, related stimulus. In video games, this means that early cues (visuals, sounds, narrative hints or tutorial tasks) can set players’ expectations or readiness for what comes next.

In this experiment, I focused on visual priming. Each of the three in-game cars was accompanied by a unique set of visuals and performance specifications, despite all cars sharing the exact same physical properties and code. By doing so, I aimed to investigate whether these superficial differences would lead players to perceive one car as faster than the others.

# Game Design

I developed the game in Unity and designed it as a simple endless traffic simulator. It featured three distinct car models, each visually and descriptively framed to appear different in terms of speed and performance.

However, under the hood, all three cars were functionally identical:

- Same mass
- Identical wheel colliders
- Shared `CarController` script managing speed and control

Players began at a car selection screen, where each car was presented with a unique name, model, and set of superficial specifications. Upon selection, players drove their chosen vehicle through an endless traffic environment.

# Experiment

Thirteen participants took part in the experiment, who were given the game and asked to complete a Google Form survey consisting of multiple sections to assess the perceived vehicle performance. Their gaming experience distribution was as follows:

- Daily players: 23.1% (n=3)
- Weekly players: 15.4% (n=2)
- Occasional players: 46.2% (n=6)
- Non-players: 15.4% (n=2)

### Visual Priming Implementation

Each vehicle was associated with specific visual and statistical presentations designed to establish performance expectations:

**Car A**

- Visual: Standard sedan-type model
- Stats: Moderately balanced attributes

**Car B**

- Visual: Fast racecar-type model
- Stats: Framed as the fastest and most powerful car

**Car C**

- Visual: Strong SUV-type model
- Stats: Framed as heavy but stable, not particularly fast

# Result

Despite being mechanically identical, the cars received significantly different speed ratings from the participants. Given that each participant rated all three cars, I decided to conduct a paired t-test to determine whether the differences in perceived speed were statistically significant.

### Statistics

| Metric | Car A | Car B | Car C |
| --- | --- | --- | --- |
| Number of Observations | 13 | 13 | 13 |
| Mean | 5.38 | 7.85 | 4.54 |
| Median | 5.00 | 8.00 | 4.00 |
| Standard Deviation (SD) | 1.33 | 1.29 | 1.82 |
| Variance | 1.78 | 1.66 | 3.31 |
| Minimum | 3 | 4 | 2 |
| Maximum | 7 | 9 | 8 |
| Range | 4 | 5 | 6 |
| Interquartile Range (IQR) | 2.00 | 1.00 | 2.00 |

### Car B vs Car A

- Mean difference (Car B - Car A): 2.46
- t-value: 5.33
- Degrees of freedom: 12
- p-value: 0.000178 (significant at α=0.05)
- 95% Confidence Interval of difference: [1.46, 3.47]

**Interpretation:**

Since the p-value < 0.05, we reject the null hypothesis.
This means that there is a statistically significant difference between the speeds of Car B and Car A. In particular, Car B is perceived as significantly faster than Car A.

### Car B vs Car C

- Mean difference (Car B - Car C): 3.31
- t-value: 8.65
- Degrees of freedom: 12
- p-value: <0.00001 (significant at α=0.05)
- 95% Confidence Interval of difference: [2.48, 4.14]

**Interpretation:**

Since the p-value < 0.05, we reject the null hypothesis.
This means that there is a statistically significant difference between the speeds of Car B and Car C. In particular, Car B is perceived as significantly faster than Car C.

# Conclusion

The findings statistically indicate that Car B was perceived as substantially faster than both Car A and Car C despite identical mechanical properties. While these results may not carry significant real-world implications, the project has been a valuable opportunity to apply my first-year knowledge in a practical research context.
