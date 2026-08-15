# Product Images Setup Guide

## Folder Structure
```
wwwroot/images/products/
├── laptops/
│   ├── asus-rog.jpg
│   ├── lenovo-legion.jpg
│   └── dell-xps.jpg
├── desktops/
│   ├── hp-pavilion.jpg
│   └── nzxt-builder.jpg
├── monitors/
│   ├── lg-4k-monitor.jpg
│   └── dell-24-monitor.jpg
├── peripherals/
│   ├── logitech-mx-master.jpg
│   └── corsair-keyboard.jpg
└── components/
    ├── intel-i9.jpg
    ├── nvidia-4090.jpg
    └── corsair-ram.jpg
```

## How to Add Images

### Option 1: Download from Internet URLs
You can find product images from:
- **Laptops**: Amazon, ASUS official site, Lenovo, Dell
- **Desktops**: HP, NZXT official sites
- **Monitors**: LG, Dell official sites
- **Peripherals**: Logitech, Corsair official sites
- **Components**: Intel, NVIDIA, Corsair official sites

### Option 2: Use Placeholder Images
For now, you can use these free image sources:
- Unsplash.com
- Pexels.com
- Pixabay.com
- Lorem Picsum (placeholder images)

### Steps to Add Images

1. **Find Image URL**
   - Google search: "ASUS ROG Zephyrus laptop"
   - Right-click → Copy image address

2. **Download Image**
   - Paste URL in browser
   - Save image (Ctrl+S or right-click → Save image as)
   - Choose appropriate folder:
     - Laptops → `wwwroot/images/products/laptops/`
     - Desktops → `wwwroot/images/products/desktops/`
     - etc.

3. **Rename Image**
   - Use naming convention: `lowercase-with-dashes.jpg`
   - Examples:
     - `asus-rog.jpg`
     - `lenovo-legion.jpg`
     - `dell-xps.jpg`

4. **Update Code (if needed)**
   - Image paths are stored in `AppDbInitializer.cs`
   - Current format: `/images/products/{category}/{image-name}.jpg`
   - Example: `/images/products/laptops/asus-rog.jpg`

## Sample Product Image Sources

### Laptops
- ASUS ROG Zephyrus: https://www.asus.com/support/download/
- Lenovo Legion: https://www.lenovo.com/us/en/p/laptops/
- Dell XPS: https://www.dell.com/en-us/

### Desktops
- HP Pavilion: https://www.hp.com/us-en/shop/
- NZXT Builder: https://www.nzxt.com/

### Monitors
- LG 27" 4K: https://www.lg.com/us/
- Dell S2421H: https://www.dell.com/en-us/

### Peripherals
- Logitech MX Master: https://www.logitech.com/
- Corsair K95: https://www.corsair.com/

### Components
- Intel i9: https://www.intel.com/
- NVIDIA RTX 4090: https://www.nvidia.com/
- Corsair RAM: https://www.corsair.com/

## Current Image Paths in Database Seed

The following paths are configured in `AppDbInitializer.cs`:
- Laptops: `/images/products/laptops/{name}.jpg`
- Desktops: `/images/products/desktops/{name}.jpg`
- Monitors: `/images/products/monitors/{name}.jpg`
- Peripherals: `/images/products/peripherals/{name}.jpg`
- Components: `/images/products/components/{name}.jpg`

## Testing

1. Run application: `dotnet run`
2. Navigate to Products → Details
3. Check if images load correctly
4. If images don't show, verify:
   - Image file exists in correct folder
   - Image path in database matches actual file name
   - Image format is supported (jpg, png, gif, webp)

## Notes

- Images are served from `wwwroot/images/products/`
- Web server serves files in wwwroot as static files
- Keep image file sizes reasonable (< 1MB each)
- Use `.jpg` or `.png` format for best compatibility
- Update database seed data if image names change
