# EdgeDetect

A simple C# .NET project for edge detection in images using operators such as **Sobel** and **Prewitt**.  
This project was developed as a learning exercise in image processing and C#.

---

## Project Structure

- **EdgeDetect** → Main application (handles CLI, image processing).  
- **EdgeDetect.Tests** → Unit tests for operators and edge detection.  
- **docs/diagram.png** → UML class diagram of the project architecture.  

---

## Build

To build the project, run:

```bash
dotnet build
```

---

## Run

To run the program manually, use:

```bash
dotnet run --project EdgeDetect -- <operator> <input-image> <output-image>
```

Example (using Sobel):

```bash
dotnet run --project EdgeDetect -- sobel input.png output.png
```

This applies the Sobel operator on `input.png` and saves the edge-detected result to `output.png`.

Available operators:
- `sobel`
- `prewitt`

---

## Test

Unit tests are included in `EdgeDetect.Tests`.

Run them with:

```bash
dotnet test
```

The tests cover:
- **EdgeOperatorFactoryTests** → Ensures the correct operator is returned.  
- **EdgeDetectionSimpleImageTests** → Creates a synthetic test image and confirms edges are detected.  

---

## UML Diagram

The system structure is shown below:

![UML Diagram](docs/diagram.png)

---

## Author

Developed by **Min Zay Ya (Kuroneko)**  
[minzayya.augustinerichard@gmail.com](mailto:minzayya.augustinerichard@gmail.com)  
[LinkedIn](https://www.linkedin.com/in/minzayya-kuroneko) | [GitHub](https://github.com/kuroNeko-23)

---
