public record UserBook(int userRam, int userRom,   String userOS, String userColor) {

    public String toString() {
        return " Main memory: " + this.userRam + "GB, Hard disc value: " +
                this.userRom + ", Operating system: " + this.userOS + ", Color: " + this.userColor;
    }
}