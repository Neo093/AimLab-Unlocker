# 🎯 AimLab Unlocker

A lightweight plugin for **Aim Lab** that unlocks premium features and cosmetics.  
Built using **C#**, **Harmony**, and **BepInEx (IL2CPP)**.

---

## ✨ What This Does
- 🔓 Unlocks premium/subscription features  
- 🎨 Unlocks skins and cosmetic items  
- ⚡ Runs automatically when the game starts  
- 🛠 Simple plug-and-play setup  

---

## 📦 Requirements
- Aim Lab (Steam version)  
- BepInEx **IL2CPP x64 (Bleeding Edge)**  

---

## 🚀 Installation

### 1. Install BepInEx
1. Download **BepInEx IL2CPP x64**
2. Extract it into your Aim Lab folder  
   Example:Steam/steamapps/common/Aim Lab
3. Run the game once (important)
4. Close the game  

---

### 2. Install Plugin
1. Download `AimLabUnlocker.dll`  
2. Move it to: Aim Lab/BepInEx/plugins/
3. Launch the game  

Done ✅

---

## ⚙️ Optional (Hide Console)
1. Open: Aim Lab/BepInEx/config/BepInEx.cfg
2. Find: [Logging.Console]
          Enabled = true
3. Change to: Enabled = false

---

## 💻 Build From Source

### Requirements
- Visual Studio 2022  
- .NET 6 SDK  

### Steps
1. Clone the repository  
2. Open `.sln` in Visual Studio  
3. Fix references:
- `UnityEngine.dll`
- `Il2CppSystem.dll`

Located in: Aim Lab/BepInEx/interop

4. Build in **Release mode**

Output: bin/Release/net6.0/AimLabUnlocker.dll

---

## 📁 Project Files
- `Plugin.cs` → Main loader  
- `Patches.cs` → Unlock logic  
- `.csproj` → Project config  

---

## ⚠️ Notes
- Use only **IL2CPP version** of BepInEx  
- Run the game once before installing plugin  
- Check logs if issues: BepInEx/LogOutput.log

---

## ❗ Disclaimer
This project is for educational purposes only.  
Using mods may violate the game's Terms of Service.  
Use at your own risk.
