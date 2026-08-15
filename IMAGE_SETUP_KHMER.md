# 📸 ការដាក់រូបផលិតផល - Computer Shop

## 📂 ឯកសារលម្អិត

```
wwwroot/images/products/
├── laptops/
│   ├── .gitkeep
│   ├── asus-rog.jpg
│   ├── lenovo-legion.jpg
│   └── dell-xps.jpg
├── desktops/
│   ├── .gitkeep
│   ├── hp-pavilion.jpg
│   └── nzxt-builder.jpg
├── monitors/
│   ├── .gitkeep
│   ├── lg-4k-monitor.jpg
│   └── dell-24-monitor.jpg
├── peripherals/
│   ├── .gitkeep
│   ├── logitech-mx-master.jpg
│   └── corsair-keyboard.jpg
└── components/
    ├── .gitkeep
    ├── intel-i9.jpg
    ├── nvidia-4090.jpg
    └── corsair-ram.jpg
```

---

## 🖼️ របៀបដាក់រូបផលិតផល

### ជំហានលេខ 1: រកលើ Internet

```
ឧទាហរណ៍: រក ASUS ROG Zephyrus laptop

1. ចូលលើ Google: https://google.com
2. វាយ: "ASUS ROG Zephyrus gaming laptop"
3. ចូលដោះលែង → រូបភាព
4. ស្វាង់រូបដែលល្អ → click វាថ្ងៃវាង
5. Right-click លើរូប → Copy image address
```

**ឡើងហើយ:** 
- ASUS: https://www.asus.com
- Lenovo: https://www.lenovo.com
- Dell: https://www.dell.com
- HP: https://www.hp.com
- LG: https://www.lg.com
- Corsair: https://www.corsair.com
- Logitech: https://www.logitech.com

---

### ជំហានលេខ 2: រក្សាទុកលើ Local

```
១. បើក Browser លម្អិត (Google Chrome ឬ Firefox)
២. ធ្វើបិតិ្តលើ URL bar → Paste link ដែលបានចម្លង
៣. ឈានទៅលើរូប
៤. Right-click លើរូប → "Save image as" (រក្សាទុករូប)
៥. ជ្រើស folder ដែលសមស្របៈ
   - Laptop → wwwroot/images/products/laptops/
   - Desktop → wwwroot/images/products/desktops/
   - Monitor → wwwroot/images/products/monitors/
   - Peripheral → wwwroot/images/products/peripherals/
   - Component → wwwroot/images/products/components/
៦. ប្តូរឈ្មោះ file៖ "asus-rog.jpg" (មិនលើសលម្អិត)
៧. Click Save
```

---

### ជំហានលេខ 3: ឈ្មោះរូបផលិតផល

**ប្រើឈ្មោះដូចខាងក្រោម:**

#### Laptops
- asus-rog.jpg
- lenovo-legion.jpg
- dell-xps.jpg

#### Desktops
- hp-pavilion.jpg
- nzxt-builder.jpg

#### Monitors
- lg-4k-monitor.jpg
- dell-24-monitor.jpg

#### Peripherals
- logitech-mx-master.jpg
- corsair-keyboard.jpg

#### Components
- intel-i9.jpg
- nvidia-4090.jpg
- corsair-ram.jpg

---

## 📋 ឯកសារលម្អិត

ឯកសារលម្អិតបានដាក់រួចហើយ ក្នុង **AppDbInitializer.cs**:

```csharp
// Laptops
ImagePath = "/images/products/laptops/asus-rog.jpg"
ImagePath = "/images/products/laptops/lenovo-legion.jpg"
ImagePath = "/images/products/laptops/dell-xps.jpg"

// Desktops
ImagePath = "/images/products/desktops/hp-pavilion.jpg"
ImagePath = "/images/products/desktops/nzxt-builder.jpg"

// Monitors
ImagePath = "/images/products/monitors/lg-4k-monitor.jpg"
ImagePath = "/images/products/monitors/dell-24-monitor.jpg"

// Peripherals
ImagePath = "/images/products/peripherals/logitech-mx-master.jpg"
ImagePath = "/images/products/peripherals/corsair-keyboard.jpg"

// Components
ImagePath = "/images/products/components/intel-i9.jpg"
ImagePath = "/images/products/components/nvidia-4090.jpg"
ImagePath = "/images/products/components/corsair-ram.jpg"
```

---

## ✅ ការពិនិត្យលម្អិត

```
១. ចាប់ផ្តើម Application: dotnet run
២. ចូលទៅលើ: https://localhost:5001
៣. ចូល Products → Details
៤. ពិនិត្យរូប

ប្រសិនបើរូបមិនឃើញ៖
   - ឆែកថាឯកសារមាននៅលើ folder ដែលត្រឹមត្រូវ
   - ឆែកឈ្មោះឯកសារ (case-sensitive)
   - ឆែកម៉ាន់ type: .jpg ឬ .png
```

---

## 💡 ដំបូល

- រូបមិនមិនលើស 1MB ក្នុងមួយ
- ប្រើ `.jpg` ឬ `.png` រឹងល្អ
- រូបដែលល្អ = ឧទាហរណ៍ 800x600 ឬ 1000x800 pixels
- រូបបង្ហាញលម្អិត ក្នុង Views

---

## 🔗 Image Sources (ឯកសារលម្អិត)

**Products ឯកសារលម្អិត:**
- Laptops: Amazon, ASUS, Lenovo, Dell sites
- Desktops: HP, NZXT, Amazon
- Monitors: LG, Dell, BenQ, Amazon
- Peripherals: Logitech, Corsair, Razer
- Components: Intel, NVIDIA, Corsair, AMD

---

**រូប:** ខ្ញុំបានបង្កើត folders និងផ្លាស់ប្តូរ image paths រួចហើយ!

ឧឹង:**https://github.com/Rotananob/computer-shop-ASP.Net-core-lab**
