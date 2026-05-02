# 🎯 AimLab Unlocker

A lightweight **BepInEx** plugin for Aim Lab (IL2CPP) designed to unlock various in-game features, including subscriptions and cosmetics. Built using C# and the Harmony patching library.

---

## ✨ Features
* **Subscription Bypass**: Automatically unlocks premium features by patching identity checks.
* **Skin & Cosmetic Unlocker**: Grants access to weapon skins, arm skins, and catalog items[cite: 2].
* **Safe Loading**: Includes built-in error reporting with Windows MessageBox alerts if the game fails to patch.

---

## 🛠 Prerequisites
Before installing, ensure you have the following:
* **Aim Lab** installed via Steam.
* **BepInEx 6.0 (IL2CPP x64)**: Use the latest "Bleeding Edge" builds from [BepInBuilds](https://builds.bepinex.dev/projects/bepinex_be).

---

## 🚀 Installation

### 1. Setup BepInEx
1. Download the **BepInEx Unity IL2CPP x64** zip file.
2. Extract the contents into your Aim Lab game folder (e.g., `C:\Program Files (x86)\Steam\steamapps\common\Aim Lab`).
3. Launch the game once. Wait for the console to finish generating "interop" files—this may take a few minutes. Close the game once you reach the main menu.

### 2. Install the Plugin
1. Download the latest `AimLabUnlocker.dll` from the **Releases** page.
2. Move the `.dll` file into:  
   `Aim Lab/BepInEx/plugins/`
3. Launch Aim Lab and enjoy the unlocked features!

---

## ⚙️ Configuration
To disable the BepInEx console window for a cleaner desktop:
1. Navigate to `Aim Lab/BepInEx/config/BepInEx.cfg`.
2. Find `Enabled` under the `[Logging.Console]` section and set it to `false`.

---

## 💻 Building from Source
If you want to modify the code or compile it yourself:

### Requirements
* **Visual Studio 2022** (with the ".NET desktop development" workload).
* **.NET 6.0 SDK** or higher.

### Steps
1. **Clone the Repository**:
   ```bash
   git clone [https://github.com/your-username/AimLabUnlocker.git](https://github.com/your-username/AimLabUnlocker.git)
