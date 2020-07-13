/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package microsoft.bonsai.simulatorapi.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Idle Event.null It means, that no RL action was yet available for this
 * session.
 */
public class Idle {
    /**
     * callback time in seconds. this mean,s you should wait for this much time
     * before sending a new advance request.
     */
    @JsonProperty(value = "callbackTime")
    private Double callbackTime;

    /**
     * Get callback time in seconds. this mean,s you should wait for this much time before sending a new advance request.
     *
     * @return the callbackTime value
     */
    public Double callbackTime() {
        return this.callbackTime;
    }

    /**
     * Set callback time in seconds. this mean,s you should wait for this much time before sending a new advance request.
     *
     * @param callbackTime the callbackTime value to set
     * @return the Idle object itself.
     */
    public Idle withCallbackTime(Double callbackTime) {
        this.callbackTime = callbackTime;
        return this;
    }

}