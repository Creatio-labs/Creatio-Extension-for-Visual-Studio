using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

namespace $rootnamespace$
{
    #region Class: $safeitemrootname$

    [EntityEventListener(SchemaName = "SPECIFY_ENTITY_SCHEMA_NAME")]
    public class $safeitemrootname$ : BaseEntityEventListener
    {
        #region Methods: Public

        public override void OnInserted(object sender, EntityAfterEventArgs e)
        {
            base.OnInserted(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnInserting(object sender, EntityBeforeEventArgs e)
        {
            base.OnInserting(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnSaved(object sender, EntityAfterEventArgs e)
        {
            base.OnSaved(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnSaving(object sender, EntityBeforeEventArgs e)
        {
            base.OnSaving(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnUpdated(object sender, EntityAfterEventArgs e)
        {
            base.OnUpdated(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnUpdating(object sender, EntityBeforeEventArgs e)
        {
            base.OnUpdating(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnDeleted(object sender, EntityAfterEventArgs e)
        {
            base.OnDeleted(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        public override void OnDeleting(object sender, EntityBeforeEventArgs e)
        {
            base.OnDeleting(sender, e);

            var entity = (Entity)sender;
            var userConnection = entity.UserConnection;

            //TODO your business logic
        }

        #endregion
    }

    #endregion
}
