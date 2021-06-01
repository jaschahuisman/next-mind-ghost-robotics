# Next-mind ghost-robotics

Next-mind brain computer interface for the [ghost robotics vision 60](https://www.ghostrobotics.io/) robot dog.

<img src="./Assets/Images/robot-dog_01.png" width="400" alt="Robot dog" title="Doggo"/>

### Table of contents

-   [About](#about)
-   [Usage](#usage)
-   [Next-Mind](#next-mind)
-   [Unity API controller usage](#unity-api-controller-usage)

### About

Together with computer science students from [Avans Hogeschool](https://www.avans.nl/) we're working on a project to use the next-mind brain computer interfacing mechanism to control the ghost-robotics vision 60 robot dog.

<hr>

### Usage

1. Start the testing server:

```bash
npm run start
```

2. Connect the Next-Mind BCI to your device using bluetooth.
3. Open the Unity project.
4. Start the game view.
5. Focus your mind to the UI.
6. Check the server log output.

<hr>

### Next-Mind

[Next-mind](https://www.next-mind.com) is a consumer brain computer interface (BCI) product that allows users to control actions with their mind/focus. Next-mind delivered a [Unity SDK](https://www.next-mind.com/developer) that's accessible to use for Next-Mind development.

[Read the Next-Mind documentation](https://www.next-mind.com/documentation)

<hr>

### Unity API controller usage

To make a connection to a device, (in this use-case it's the [ghost robotics vision 60](https://www.ghostrobotics.io/)), the `API_Controller.cs` class comes in handy.

Using the `Trigger()` method at the NeuroTag's onTrigger() handlers, the IEnumerators in the API_Controller class can be accessed.

Example:

```cs
Trigger('sit') // triggers IEnumerator Sit()
```
