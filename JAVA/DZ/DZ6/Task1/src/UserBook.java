public record UserBook() {
    private static int userRam;
    private static int userRom;
    private static String userOS;
    private static String userColor;
    public String toString() {
        return " Main memory: " + this.userRam + "GB, Hard disc value: " +
                this.userRom + ", Operating system: " + this.userOS + ", Color: " + this.userColor;
    }
    public int getUserRam() {
        return userRam;
    }

    public void setUserRam(int ram) {
        userRam = ram;
    }

    public int getRom() {
        return userRom;
    }

    public void setRom(int rom) {
        this.Rom = rom;
    }

    public String getOS() {
        return OS;
    }

    public void setOS(String OS) {
        this.OS = OS;
    }

    public String getColor() {
        return Color;
    }

    public void setColor(String color) {
        Color = color;
}