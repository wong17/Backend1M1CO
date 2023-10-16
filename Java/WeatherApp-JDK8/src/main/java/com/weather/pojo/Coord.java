/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.weather.pojo;

/**
 *
 * @author Yasser
 */
public class Coord {
    private double lon;
    private double lat;

    public Coord(double longitud, double latitude) {
        this.lon = longitud;
        this.lat = latitude;
    }

    public double getLongitud() {
        return lon;
    }

    public void setLongitud(double longitud) {
        this.lon = longitud;
    }

    public double getLatitude() {
        return lat;
    }

    public void setLatitude(double latitude) {
        this.lat = latitude;
    }
    
}
