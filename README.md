
# Amir.Utils

A simple and reusable .NET utility library that provides helpful methods for working with strings and dates.

> Built with ❤️ by **Amir Hamza**  
> Target Framework: `.NET 8.0`  
> Compatible with: `.NET 8`

---

## ✨ Features

- 🔤 **String utilities**
  - Convert strings to Title Case
  - Generate URL slugs
  - Remove special characters

- 📅 **DateTime helpers**
  - Human-readable relative time (`45 minutes ago`)
  - Check if a date is on a weekend
  - Calculate business days between two dates

- ⚙️ Lightweight and extensible  
- 🧪 Great for real-world use or learning clean library structure

---

## 📦 Installation

### 🔹 Clone the Repo

```bash
git clone https://github.com/your-username/Amir.Utils.git
```

### 🔹 How to Use Locally

- Add the `Amir.Utils` project to your solution  
- Reference it from your main application  
- Use the helpers via:

```csharp
using Amir.Utils.Helpers;
```

> _NuGet support coming soon!_

---

## 🧰 Usage

```csharp
using Amir.Utils.Helpers;

// String Utilities
string title = StringHelper.ToTitleCase("hello from amir!");
string slug = StringHelper.Slugify("Hello, World! This is a test.");
string cleaned = StringHelper.RemoveSpecialCharacters("Hi@# Amir!");

// DateTime Utilities
string readable = DateTimeHelper.ToHumanReadable(DateTime.UtcNow.AddMinutes(-45));
bool isWeekend = DateTimeHelper.IsWeekend(DateTime.Now);
int bizDays = DateTimeHelper.BusinessDaysBetween(DateTime.Now.AddDays(-10), DateTime.Now);
```

---

## 📁 Project Structure

```
Amir.Utils/
├── Amir.Utils.csproj
└── Helpers/
    ├── StringHelper.cs
    └── DateTimeHelper.cs

Amir.Utils.Demo/
└── Program.cs
```

---

## 🛠️ Built With

- Language: **C#**
- Framework: **.NET 8 **
- IDE: **Visual Studio 2022**

---

## ✅ To Do

- [ ] Add unit tests
- [ ] Publish to NuGet
- [ ] Add XML documentation comments
- [ ] Add more helper classes (Math, File, etc.)

---

## 🌐 Connect with Me

- 💼 [LinkedIn](https://www.linkedin.com/in/amir-hamza-SoftEng/)
- 💬 Feel free to open issues or contribute!
- ⭐ If you like the project, star it on GitHub!

---

> Happy coding! 💻✨
