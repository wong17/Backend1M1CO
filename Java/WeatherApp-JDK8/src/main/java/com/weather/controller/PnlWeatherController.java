/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.weather.controller;

import java.net.MalformedURLException;
import java.net.URL;
import javax.swing.ImageIcon;
import net.aksingh.owmjapis.api.APIException;
import net.aksingh.owmjapis.core.OWM;
import net.aksingh.owmjapis.model.CurrentWeather;

/**
 *
 * @author Wong
 */
public class PnlWeatherController {
    
    private OWM owm;
    private CurrentWeather cwd;
    private String url ;
    
    public PnlWeatherController() {
        this.url = "http://openweathermap.org/img/w/";
    }

    //OBTENEMOS EL CLIMA ACTUAL DE LA CIUDAD, NOS DEVUELVE UN OBJETO DE TIPO CurrentWeather
    private CurrentWeather getCurrentWeather(String cityName) throws APIException {
        owm = new OWM("0f995113ea7931bbc41724930f2ae37e");
        cwd = owm.currentWeatherByCityName(cityName);
        return cwd;
    }

    public CurrentWeather getWeather(String cityName) throws APIException {
        return getCurrentWeather(cityName);
    }
    
    public ImageIcon getImageUrl(String imageCod) throws MalformedURLException{
        URL myurl = new URL(url+imageCod + ".png");        
        ImageIcon img = new ImageIcon(myurl, imageCod);        
        return img;
    }
}
