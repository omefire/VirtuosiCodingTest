using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosiCodingTest.Question_1
{
    public interface IParticleSystem
    {
        /// <summary>
        /// Creates a new particle emitter instance based on the given type ID.
        /// </summary>
        /// <param name="typeId">The ID specifying the emitter settings.</param>
        /// <returns>An instance of a particle emitter.</returns>
        ParticleEmitter CreateEmitter(int typeId);

        /// <summary>
        /// Attaches a particle emitter instance to a model, a world location, or a screenspace location.
        /// </summary>
        /// <param name="emitter">The particle emitter instance.</param>
        /// <param name="location">The location where the emitter should be placed (e.g., world or screenspace coordinates).</param>
        void AttachEmitter(ParticleEmitter emitter, Location location);

        /// <summary>
        /// Scales and/or rotates the given particle emitter instance.
        /// </summary>
        /// <param name="emitter">The particle emitter instance.</param>
        /// <param name="scale">The scaling factor to be applied.</param>
        /// <param name="rotation">The rotation to be applied (e.g., in degrees or radians).</param>
        void TransformEmitter(ParticleEmitter emitter, float scale, float rotation);

        /// <summary>
        /// Terminates the particle emitter instance early.
        /// </summary>
        /// <param name="emitter">The particle emitter instance to terminate.</param>
        void TerminateEmitter(ParticleEmitter emitter);
    }

    // Supporting classes to represent a ParticleEmitter and Location.
    public class ParticleEmitter
    {
        // Properties and methods for a particle emitter can be implemented later.
    }

    public class Location
    {
        // Represents a location in the world or screenspace. Implementation can include coordinates and type.
    }
}
